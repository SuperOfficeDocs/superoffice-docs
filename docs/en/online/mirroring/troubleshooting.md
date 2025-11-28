---
title: Troubleshooting Database Mirroring
uid: mirroring_troubleshooting
description: Troubleshooting Database Mirroring
author: Anthony Yates
keywords: database mirroring
content_type: howto
deployment: online
platform: web
---

# Troubleshooting Database Mirroring

The most common problems during setup and configuration of Database Mirroring are:

* unavailable service
* validation error

## Unavailable service

> [!NOTE]
> This section assumes your service is hosted as a WCF service in IIS.

The most common error message observed is the unavailability of a customer Database Mirroring endpoint.

```txt
The HTTP service located at https://{your database mirror url}/Mirroring/MirroringClientService.svc is unavailable. 
This could be because the service is too busy or because no endpoint was found listening at the specified address. 
Please ensure that the address is correct and try accessing the service again later.
```

This is often observed in the log files as seen here.

![unavailable wcf service error message -screenshot][wcf-unavailable]

This problem is difficult to understand because viewing the web service in IIS delivers the expected WCF service web page.

![iis wcf service page -screenshot][wcf-iis-page]

The error message in this case is misleading. To better understand what's going on is to know that, when viewing a WCF service in IIS, the page is served as a response to a GET request in the browser. The Database Mirroring service, however, sends POST requests to the customers web server. Therein lies the difference, and what often obscures the problem.

This can easily be verified by issuing a POST request to the Database Mirror URL. The following example is useful for testing this theory.

> [!NOTE]
> The following example contains an invalid JWT token, and does not affect the point of testing service availability.

```http
POST https://DATABASE-MIRROR-URL/MirroringClientService.svc HTTP/1.1
Content-Type: text/xml;charset=UTF-8
SOAPAction: http://www.superoffice.com/online/mirroring/0.1/IMirroringClientService/Authenticate

<s:Envelope xmlns:s="http://schemas.xmlsoap.org/soap/envelope/">
  <s:Header>
    <SignedToken s:mustUnderstand="1" 
       xmlns="http://www.superoffice.com/online/mirroring/0.1">eyJhbsyNmwg</SignedToken>
  </s:Header>
  <s:Body>
    <AuthenticateRequest 
       xmlns="http://www.superoffice.com/online/mirroring/0.1">
      <ClientState/>
    </AuthenticateRequest>
  </s:Body>
</s:Envelope>
```

The expected response in this case is an HTTP 404 status response.

![iis 404 response -screenshot][wcf-404]

If this is the case, then the connectivity issue is likely caused by permissions settings on the IIS server. Because IIS servers have a wide variety of purposes, and can be configured quite differently, this text will remain IIS settings agnostic and focus on fixing the observed error.

When the Database Mirroring service is available to GET requests but unavailable to POST requests, the Mirroring Service configuration will then likely require the additional security element in the basicHttpBinding configuration. SuperOffice uses certificates to establish a secure connection, and does not require credentials, therefore the `clientCredentialType` is set to None.

```xml
<bindings>
  <basicHttpBinding>
    <binding name="DbMirroring"
             maxBufferPoolSize="2147483647"
             maxReceivedMessageSize="2147483647"
             maxBufferSize="2147483647">
      
      <!-- Add this following security element -->  
      <security mode="Transport">
          <transport clientCredentialType="None" />
      </security>
      
      <readerQuotas maxDepth="2147483647"
                    maxStringContentLength="2147483647"
                    maxArrayLength="2147483647"
                    maxBytesPerRead="2147483647"
                    maxNameTableCharCount="2147483647" />
    </binding>
  </basicHttpBinding>
</bindings>
```

> [!NOTE]
> If the WCF service returns a 404 when the security element is present, remove the security element from the basicHttpBinding binding section and try again.

If your network infrastructure has more complex requirements, please consult the Microsoft [WCF bindings and security](https://docs.microsoft.com/en-us/dotnet/framework/wcf/feature-details/bindings-and-security) documentation for guidance, or review the [security transport](https://docs.microsoft.com/en-us/dotnet/framework/configure-apps/file-schema/wcf/transport-of-basichttpbinding) documentation.

## Validation errors

The Database Mirroring service initiates synchronization by passing a signed security token to the Database Mirroring endpoint, which the endpoint is expected to validate. The endpoint is then expected to create and sign a security token as well, and send that back to SuperOffice to validate. Only after SuperOffice has validated the returned signed token will the Database Mirroring service begin to send data.

Assuming the endpoint is using the [SuperOffice.Crm.Online.Mirroring](https://www.nuget.org/packages/SuperOffice.Crm.Online.Mirroring) NuGet library, when token validation fails an error message similar to the following is returned to SuperOffice:

```txt
Exception: 
Failed validating token
    at SuperOffice.SuperID.Client.Tokens.SuperIdTokenHandler.ValidateJwtToken(
        String token, ClaimsPrincipal&amp; claimsPrincipal) 
        in C:\Agent1\_work\3\s\Source\SuperOffice.SuperID.Client\Tokens\SuperIdTokenHandler.cs:line 187&#xD;
    at SuperOffice.Online.Mirroring.MirroringClientService.ValidateSuperOfficeSignedToken(String token) in 
        C:\Agent1\_work\3\s\Source\SuperOffice.Online.Mirroring\MirroringClientService.cs:line 137&#xD;
    at SuperOffice.Online.Mirroring.MirroringClientService.Authenticate(AuthenticateRequest request) in 
        C:\Agent1\_work\3\s\Source\SuperOffice.Online.Mirroring\MirroringClientService.cs:line 20
```

Token validation is built the NuGet package libraries, but requires the public SuperOffice certificates be [added the certificate store][0] on the server running IIS.

Alternatively, the Database Mirroring endpoint can skip adding the certificates to the certificate store and instead override the `ValidateSuperOfficeSignedToken` method and use only the `SuperOfficeFederatedLogin.crt` certificate to validate the signed token sent from SuperOffice.

```cs
protected override SuperIdToken ValidateSuperOfficeSignedToken(string token)
{
    // perform validation using a the SuperOfficeFederatedLogin.crt certificate
    // then return a SuperIdToken, from SuperOffice.Crm.Online.Core package
    // https://www.nuget.org/packages/SuperOffice.Crm.Online.Core/

    var tokenHandler = new SuperIdTokenHandler(); 
    
    tokenHandler.JwtIssuerSigningCertificate = new X509Certificate2(
       HostingEnvironment.MapPath("~/App_Data/") + "SuperOfficeFederatedLogin.crt"
    );

    // Change subdomain for correct environment (sod, stage, online).
    tokenHandler.ValidIssuer = "SuperOffice AS";
    tokenHandler.CertificateValidator = X509CertificateValidator.None;

    return tokenHandler.ValidateToken(token, TokenType.Jwt);
}
```

## Explicit Validation

While extremely rare, it is possible to host a Database Mirroring endpoint by implementing the WSDL. Such endpoints must do everything, from validating the JWT to populating a database with the incoming data from SuperOffice, on their own. We strongly discourage all from attempting it, and we so not support it.

What is shared is how to validate the incoming JWT, sign and sent a signed response.

The incoming authentication request from SuperOffice contains a signed JWT token in the *Header* element `SignedToken`. Seen below, a majority of the token has been removed for brevity.

```xml
<s:Envelope
    xmlns:s="http://schemas.xmlsoap.org/soap/envelope/">
    <s:Header>
        <h:SignedToken s:mustUnderstand="1"
            xmlns:h="http://www.superoffice.com/online/mirroring/0.1">eyJhbGc...Q03yXZIsy
        </h:SignedToken>
    </s:Header>
    <s:Body>
        <AuthenticateRequest
            xmlns="http://www.superoffice.com/online/mirroring/0.1">
            <ClientState/>
        </AuthenticateRequest>
    </s:Body>
</s:Envelope>
```

To validate the token, one must extract the claims and use a few of them to set validation parameters. Claims will appear as:

![JWT claims -screenshot][authenticate-claims]

The claims of interest are:

* Iss: Issuer
* aud: Audience
* nonce: Your application will need this for the response.

### How to validate the Authentication request token

Construct a method that accepts the signed token, extract the audience and issuer from the claims, and use them to populate the corresponding properties of the validation parameters. Then, assign the public SuperOffice certificate to validate the token and perform the validation.

```csharp
using Microsoft.IdentityModel.JsonWebTokens; //Nuget Package 5.6.0

public override async Task<TokenValidationResult> ValidateAsync(string token)
{
    this.SecurityTokenHandler = new JsonWebTokenHandler()
    
    string issuer;
    string audience;
    
    // extract the ValidAudience claim value (database serial number). 
    var securityToken = SecurityTokenHandler.ReadJsonWebToken(token);
    
    // get the audience from the token
    if (!securityToken.TryGetPayloadValue<string>("aud", out audience))
    {
        throw new SecurityTokenException("Unable to read ValidAudience from System User token.");
    }
    
    // get the issuer from the token
    if (!securityToken.TryGetPayloadValue<string>("iss", out issuer))
    {
        throw new SecurityTokenException("Unable to read ValidAudience from System User token.");
    }


    var validationParameters = new TokenValidationParameters();
    validationParameters.ValidAudience = audience;
    validationParameters.ValidIssuer = issuer;

    // Use the local SuperOffice public certificate (SuperOfficeFederatedLogin)
    // available in the downloads link below
       
    var path = server.MapPath("~/App_Data/") + "SOD_SuperOfficeFederatedLogin.crt";
    validationParameters.IssuerSigningKeys = new X509SecurityKey(new X509Certificate2(path));

    // Alternative:
    // Based on ASP.NET's ConfigurationManager, use to get the 
    // Public SuperOffice certificates from the OPENID CONNECT metadata document 
    // https://sod.superoffice.com/login/.well-known/openid-configuration
    // https://sod.superoffice.com/login/.well-known/jwks
    //var configuration = await ConfigurationManager.GetConfigurationAsync().ConfigureAwait(false);
    //validationParameters.IssuerSigningKeys = configuration.JsonWebKeySet.Keys;

    var result = SecurityTokenHandler.ValidateToken(token, validationParameters);
    
    if (result.Exception != null || !result.IsValid)
    {
        throw new SecurityTokenValidationException("Failed to validate the token", result.Exception);
    }

    return result;
}

```

Read more about, and/or download, the SuperOffice public certificates on the [certificates page][0].

### How to sign the response

Using the NONCE from the JWT, and private certificate key, build a string that contains the NONCE, the datatime, and signed representation of those together, separated by periods.

It looks like this:

12345A558F193123458E50E741656789.YYYYMMDDHHMM.mwhpYcNBfFqEaL0uLkCwXB99sM/Wo7DOnhjRwsmwNAd2EmBM1z+Co=

Here is an example response:

```xml
<s:Envelope
    xmlns:s="http://schemas.xmlsoap.org/soap/envelope/">
    <s:Body>
        <AuthenticateResponse
            xmlns="http://www.superoffice.com/online/mirroring/0.1">
            <IsSuccessful>true</IsSuccessful>
            <ErrorMessage/>
            <SignedApplicationToken>12345A558F193123458E50E741656789.202109161125.OKNE8l9Y...BREVITY...1hT3a4/Q=</SignedApplicationToken>
            <SupportedInterfaces>1</SupportedInterfaces>
            <SuperOfficeMirroringBuild>4.0.0.0/Release_1</SuperOfficeMirroringBuild>
            <ClientState/>
            <AdditionalInformationJson/>
        </AuthenticateResponse>
    </s:Body>
</s:Envelope>
```

To sign the token, create a `Sign` method that accepts two parameters, the NONCE and the private XMLRSA certificate key issued to you by SuperOffice. See the code example below how to complete signing the response.

```csharp
/// <summary>
/// Sign the token according to the system user specification.
/// </summary>
/// <param name="systemUserToken">An applications unique system user key for a tenant.</param>
/// <param name="privateKey">XML Formatted RSA public key.</param>
/// <returns>Signed system user string.</returns>
public string Sign(string nonce, string privateKey)
{
    var utcNow = DateTime.UtcNow.ToString("yyyyMMddHHmm");
    var signThis = nonce + "." + utcNow;
    using (var rsaCryptoProvider = new RSACryptoServiceProvider())
    {
        rsaCryptoProvider.FromXmlString(privateKey);
        var signature = rsaCryptoProvider.SignData(Encoding.UTF8.GetBytes(signThis), "SHA256");
        return signThis + "." + Convert.ToBase64String(signature);
    }
}
```

Once the `AuthenticateResponse` is sent back to SuperOffice and validated, the data flow cycle begins. See the [Mirroring Task][1] article for more details about the mirroring processing.

## Message: Could not establish trust relationship

Message: Could not establish trust relationship for the SSL/TLS secure channel with authority 'website of their mirror client'.

This error indicates that the SuperOffice mirroring service is unable to validate the SSL certificate presented by the mirror client website. This is often due to one of the following reasons:

* The mirror client website is using a self-signed certificate. In this case, the certificate must be installed in the Trusted Root Certification Authorities store on the SuperOffice mirroring server.

* The mirror client website is using a certificate issued by a Certificate Authority (CA) that is not trusted by the SuperOffice mirroring server. In this case, the CA's root certificate must be installed in the Trusted Root Certification Authorities store on the SuperOffice mirroring server.

* The mirror client website's certificate has expired or is not yet valid. In this case, the certificate must be renewed or replaced with a valid certificate.

<!-- reference links -->
[0]: ../../api/authentication/online/certificates/index.md
[1]: mirroring-task.md

<!-- reference images -->
[wcf-iis-page]: media/database-mirror-service-iis-page.png
[wcf-unavailable]: media/database-mirror-unavailable.png
[wcf-404]: media/database-mirror-404.png
[authenticate-claims]: media/database-mirror-authenticate-jwt-claims.png
