---
uid: validate_security_tokens
title: Validate security tokens
description: How to validate security tokens
author: AnthonyYates
keywords: certificates, jwt, authentication, token, security
so.topic: howto
so.envir: cloud
so.client: online
---

# Validating security tokens

There are a few of scenarios when applications must perform token validation.

1. The first covers both when an application "installed" (approved) by a tenant administrator and when a normal user signs into the application. Validation is performed after the interactive user signs into SuperOffice and approves the application. A redirect POST request sends the user to the applications redirect URI, along with an ID token, access token, and refresh token.

2. When an application obtains a system user ticket from the partner system user service endpoint.

3. When one of the outbound services begin an invocation cycle. Outbound services include Database Mirroring, ERPSync and Quote Connector.

Token validation establishes **trust** by the authentication mechanism. It ensures that:

- The token was issued by SuperOffice
- The token was issued to this user
- The user has granted the application access to the listed operation

## What does it mean to validate tokens?

1. Verify the JWT is well-formed (has 3 period-separated sections)?
2. Parse the string and extract the Base 64 encoded components - are they valid JSON?
3. Is the signature OK?
4. Are the standard claims OK? Check there is a required **sub** claim and other OIDC claims.
5. Check the namespace-specific claims.

If any of these tests fail, the JWT should be rejected and not trusted.

Various SuperOffice services define different validation parameters used for performing validation.

## How to validate security tokens

Security token validation is an important step to ensure the token has not been compromised between SuperOffice sending it and you receiving it.

Performing validation is a straightforward process that must occur for each response that was signed by SuperOffice.

There are a couple of options to perform the actual validation:

1. Use explicit validation.

   - Use physical [SuperOffice certificates][4].
   - Use the [OpenID Connect metadata endpoint][8] to get the public certificate information from the `jwks_uri` endpoint.

2. Use [SuperOffice.WebApi][9] NuGet package written for .NET Standard 2.0.
   - This uses the [OpenID Connect metadata endpoint][8].

3. Use [SuperOffice.Online.Core][6] NuGet package for .NET Framework.

   - This requires [SuperOffice certificates][4].

## Explicit validation

This option eliminates any dependency on third party libraries to perform validation. There are three components necessary to perform token validation:

- Issuer
- Audience
- Certificate

The values used to populate validation parameters will vary depending on which SuperOffice token is validated. The table below will help guide you.

### Validation parameters

| Scenario                   | Issuer                        | Audience                 | SigningKey         |
| -------------------------- | ----------------------------- | ------------------------ | ------------------ |
| OAuth 2.0 / OpenID Connect | https://{env}.superoffice.com | Application ID           | Public certificate |
| System User                | SuperOffice AS                | spn:{serial claim value} | Public certificate |
| Connectors                 | SuperOffice AS                | spn:Application ID       | Public certificate |
| Database Mirroring         | SuperOffice AS                | spn:Application ID       | Public certificate |

For ease of understanding, rather than hard-code these values in the code sample below, the issue and audience values are extracted from the token itself, then used to set the appropriate `TokenValidationParameters` properties.

# [Sample C# Validator](#tab/dotnet)

This sample code has a System.IdentityModel.Tokens.Jwt NuGet package dependency.

```csharp
namespace Example
{
    /// <summary>
    /// SuperOffice jwt token validator
    /// </summary>
    internal class SampleValidator
    {
        public Microsoft.IdentityModel.Tokens.TokenValidationResult ValidateSuperOfficeToken(string token)
        {
            var securityTokenHandler =
                new Microsoft.IdentityModel.JsonWebTokens.JsonWebTokenHandler();

            string issuer;
            string audience;

            // extract the ValidAudience claim value (database serial number).
            var securityToken = securityTokenHandler.ReadJsonWebToken(token);

            // get the audience from the token
            if (!securityToken.TryGetPayloadValue<string>("aud", out audience))
            {
                throw new Microsoft.IdentityModel.Tokens.SecurityTokenException(
                    "Unable to read ValidAudience from token.");
            }

            // get the issuer from the token
            if (!securityToken.TryGetPayloadValue<string>("iss", out issuer))
            {
                throw new Microsoft.IdentityModel.Tokens.SecurityTokenException(
                    "Unable to read ValidAudience from token.");
            }

            var validationParameters =
                new Microsoft.IdentityModel.Tokens.TokenValidationParameters();
            validationParameters.ValidAudience = audience;
            validationParameters.ValidIssuer = issuer;

            // Option #1 *************************************************************
            // use the local SuperOffice public certificate (SuperOfficeFederatedLogin)

            var certPath = Path.Combine("Certificates", "SuperOfficeFederatedLogin.crt");
            var x509Cert = new System.Security.Cryptography.X509Certificates.X509Certificate2(certPath);
            validationParameters.IssuerSigningKey = new Microsoft.IdentityModel.Tokens.X509SecurityKey(x509Cert);

            // Option #2 *************************************************************
            // use the OpenID Connect Jwks endpoint to get the public certificate.
            
            validationParameters.IssuerSigningKeys = GetJsonWebKeys("sod");
            
            var result = securityTokenHandler.ValidateToken(token, validationParameters);

            if (result.Exception != null || !result.IsValid)
            {
                throw new Microsoft.IdentityModel.Tokens.SecurityTokenValidationException(
                    "Failed to validate the token", result.Exception);
            }
            return result;
        }

        private IList<JsonWebKey> GetJsonWebKeys(string environment)
        {
            // example only... needs exception handing...!!!
            var client = new HttpClient();
            var jwksContent = client.GetStringAsync($"https://{environment}.superoffice.com/login/.well-known/jwks");
            return JsonWebKeySet.Create(jwksContent.Result).Keys;
        }
    }
}
```

# [Sample Javascript# Validator](#tab/js)

This sample code depends on jsonwebtoken and jwks-rsa npm packages.

```javascript
var jwt = require('jsonwebtoken')
var jwksClient = require('jwks-rsa')

const myToken = 'YOUR_TOKEN_HERE'

/**
 * @param {string} env SuperOffice online environment (sod, stage, online).
 * @param {string} token  The token to validate.
 */
const validateToken = function (env, token) {
  // extract claims from token
  var claims = jwt.decode(idToken)

  const options = {
    issuer: claims.iss,
    audience: claims.aud,
  }

  // Example uses https://github.com/auth0/node-jwks-rsa as a way to fetch the keys.
  // Gets the keys from the OpenID Connect jwks_uri.

  var client = jwksClient({
    jwksUri: `https://${env}.superoffice.com/login/.well-known/jwks`,
  })

  function getKey(header, callback) {
    client.getSigningKey(header.kid, function (err, key) {
      var signingKey = key.publicKey || key.rsaPublicKey
      callback(null, signingKey)
    })
  }

  jwt.verify(token, getKey, options, function (err, decoded) {
    if (err) console.log('Error: ', err)
    else console.log(decoded)
  })
}

//perform the validation!
validateToken('sod', myToken)
```

---

## Using SuperOffice.WebApi

This NuGet package contains 2 validation classes, one for each of the 2 main validation case:

- OpenID Connect validation: `JwtTokenHandler`
- SystemUser Flow validation: `SystemUserTokenHandler`

There are 2 different token handlers because they slightly different implementations. The difference is that the `JwtTokenHandler` uses the client_id for a ValidAudience, whereas the `SystemUserTokenHandler` uses the database serial number as the ValidAudience. The latter requires additional processing to extract the database serial number from the token.

```csharp
var tokenHandler = new JwtTokenHandler(clientId, httpClient, onlineEnvironment);
TokenValidationResult result = await tokenHandler.ValidateAsync("{id_token}");
```

```csharp
var tokenHandler = new SystemUserTokenHandler(httpClient, onlineEnvironment);
TokenValidationResult result = await tokenHandler.ValidateAsync("{system_user_result}");
```

## Using SuperOffice.Online.Core

> [!CAUTION]
> This is approach is considered legacy.
> We recommend you now use one of the options above, explicit validation or the SuperOffice.WebApi libraries.

Legacy security tokens are either a [JWT][2] or [SAML][1] token. We **strongly recommend that you use JWT** tokens! SAML token support is deprecated.

The main class for processing tokens is `SuperIdTokenHandler` in the _SuperOffice.SuperID.Client_ DLL.

<a href="../../assets/downloads/superofficeonlinecertificates.zip" download>Click to download the SuperOffice certificates (ZIP file)</a>.

> [!NOTE]
> If you don't have access to the certificate store, you must substitute this procedure with a [validation override][3].

### Pre-requisites

- Either all [3 certificates][4] are installed correctly, or you override the default certificate chain used to perform validation.
- A correct thumbprint is defined in the **SuperIdCertificate** appSettings section.

### Procedure

1. Decode the token from Base64 to a string. This results in a JSON string.

2. Use an appropriate certificate validation library and the public SuperOffice certificate to validate the token:

   1. Instantiate a `SuperIdTokenHandler`.
   2. Invoke the `ValidateToken` method and pass a JWT token.

3. If and only if the token is valid, accept the claims and proceed accordingly:

   - Receive a **SuperIdToken** populated with the resulting claims.

```csharp
public SuperIdToken ValidateToken(string token)
{
    var tokenHandler = new SuperIdTokenHandler();
    return tokenHandler.ValidateToken(token, TokenType.Jwt);
}
```

Instead of depending on certificates in the local certificate store, you can <a href="../../assets/downloads/superofficeonlinecertificates.zip" download>download the public certificates</a>, including *SuperOfficeFederatedLogin.crt*, to perform token validation.

```csharp
public static SuperIdToken ValidateToken(string token)
{
  var tokenHandler = new SuperIdTokenHandler();

  tokenHandler.JwtIssuerSigningCertificate = new X509Certificate2("Certificates\\SuperOfficeDevelopment.crt");
  tokenHandler.ValidIssuer = "https://sod.superoffice.com";
  tokenHandler.CertificateValidator = X509CertificateValidator.None;
  tokenHander.ValidateAudience = false;

  return tokenHandler.ValidateToken(token, TokenType.Jwt);
}
```

If you for some reason need to use SAML tokens, simply substitute token type in step 2 (`TokenType.Saml`) and pass your SAML token. `SuperIdTokenHandler` hides the slight differences between SAML and JWT tokens.

```csharp
public static SuperIdToken ValidateToken(string token)
{
  var tokenHandler = new SuperIdTokenHandler();

  // Optionally override using certificate store, and use local certificate instead
  var certificateResolverPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"Certificates");
  tokenHandler.CertificateValidator = System.IdentityModel.Selectors.X509CertificateValidator.None;
  tokenHandler.IssuerTokenResolver = new SuperOffice.SuperID.Client.Tokens.CertificateFileCertificateStoreTokenResolver(certificateResolverPath);
  
  tokenHander.ValidateAudience = false;
  return tokenHandler.ValidateToken(token, TokenType.Saml);
}
```

### SuperIdToken

The `SuperIdToken` class is a container for security claims. It is returned after the validation of a JWT (or SAML) token and can be used for future authentication.

> [!CAUTION]
> This legacy class pertains to our [old form][11] of authentication. We recommend you now use [Use OpenID Connect][12].

`SuperIdToken` contains:

- individual properties for common claims
- a complete list of [claims][9] returned by SuperOffice CRM Online

```csharp
public class SuperIdToken
{
  public Claim[] Claims { get; }
  public string IdentityProvider { get; }
  public string Ticket { get; }
  public string NetserverUrl { get; }
  public string SystemToken { get; }
  public string Email { get; }
  public string ContextIdentifier { get; }
}
```

- **Ticket:** a SuperOffice ticket, representing the current user credential on this particular customer; not included in [OAuth flows][14]

- **NetServer_URL:** the SOAP web service endpoint for the current customer site

- **WebAPI_URL:** the RESTful endpoints for the current customer site (replaces `NetServer_URL` in class `SuperIdToken`)

- **Email:** the current user’s email address

- **ContextIdentifier (CTX):** context value (current customer ID).

- **System User Token:** a string used to exchange for a system user ticket credential

The **SuperIdToken** data type is located in the `SuperOffice.SuperID.Client.Tokens` namespace in the SuperOffice.Online.Core assembly.

### Assemblies and helper libraries

SuperOffice provides the [SuperOffice.Crm.Online.Core][6] NuGet for processing online requests. It contains the following assemblies:

- SuperOffice.Online.Core
- SuperOffice.SuperID.Client
- SuperOffice.SuperID.Contracts

We also provide [.NET helper libraries][7], which you can download.

## What is JWT anyway?

Completely new to token-based access control? We've got you covered!

JWT is short for JSON web token:

> A string representing a set of claims as a JSON object that is encoded in a JWS or JWE, enabling the claims to be digitally signed or MACed and/or encrypted. ([RFC7519][2]

A JWT has 3 parts: header, payload, signature.

![ID Token][img1]

### JWT header

The header will show that the token type is JWT and which algorithm that has been used to **sign** it.

```javascript
{
"typ":"JWT",
"alg":"HS256"
}
```

### JWT payload

The payload is the actual data of the JWT. It consists of a list of claims - each claim is a **name-value pair**.

A claim can be either [standard OpenID Connect][14] or [custom][8] (with its own namespace).

```javascript
{
  "sub": "tony@superoffice.com",
  "http://schemes.superoffice.net/identity/associateid": "5",
  "http://schemes.superoffice.net/identity/identityprovider": "central-superid",
  "http://schemes.superoffice.net/identity/email": "tony@superoffice.com",
  "http://schemes.superoffice.net/identity/upn": "tony@superoffice.com",
  "http://schemes.superoffice.net/identity/is_administrator": "False",
  "http://schemes.superoffice.net/identity/ctx": "Cust26759",
  "http://schemes.superoffice.net/identity/company_name": "Tonys Developer Network",
  "http://schemes.superoffice.net/identity/serial": "1801550193",
  "http://schemes.superoffice.net/identity/netserver_url": "https://sod.superoffice.com/Cust26759/Remote/Services86/",
  "http://schemes.superoffice.net/identity/webapi_url": "https://sod.superoffice.com/Cust26759/api/",
  "http://schemes.superoffice.net/identity/system_token": "SuperOffice DevNet Node OIDC-8k8Q7DmBgo",
  "iat": "1581665207",
  "http://schemes.superoffice.net/identity/initials": "TY",
  "http://schemes.superoffice.net/identity/so_primary_email_address": "tony@superoffice.com",
  "nonce": "637172620046685267.NmU2ZmRjNTctYjU0ZS00ZDRlLThkNjgtOTBlZmY2N2QyYjc3MzYzZWE1YjctYTUxYS00NDM1LWE1YTEtNDEzYTMxNTgxMzA0",
  "nbf": 1581665147,
  "exp": 1581665507,
  "iss": "https://sod.superoffice.com",
  "aud": "6cf25376616343b38d14ddcd804f2891"
}
```

### JWT signature

**Signatures** verify that the information was sent from the sender and that the information **has not been altered**.

<!-- Referenced links -->

[1]: http://saml.xml.org/saml-specifications
[2]: https://tools.ietf.org/html/rfc7519
[3]: certificates/override-resolver.md
[4]: certificates/index.md
[6]: https://www.nuget.org/packages/SuperOffice.Crm.Online.Core
[7]: ../../assets/downloads.md
[8]: api.md
[9]: https://www.nuget.org/packages/SuperOffice.WebApi
[11]: sign-in-user/legacy.md
[12]: sign-in-user/index.md
[14]: index.md

<!-- Referenced images -->

[img1]: media/id-token.png
