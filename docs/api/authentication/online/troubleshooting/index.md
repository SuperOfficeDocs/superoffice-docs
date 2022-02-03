---
title: Error code
uid: auth_error_codes
description: Problems with application authorization, tokens, and certificate
author: {github-id}
so.date: 01.04.2022
keywords: authorization error, token, certificate
so.topic: reference
so.envir: cloud
so.client: online
---

# Troubleshooting

Description of error codes related to authorizing an application and working with tokens.

## Problems with application authorization

### AuthorizeErrorCode

| Code | Error | Description |
|:----:|-------|-------------|
| 0 | NoError | |
| 1 | Revoked | Application's access to the tenant has been revoked |
| 2 | InvalidRedirectUrl | The redirect URL you used is not registered in the SuperOffice operation center on the app - you need to whitelist the redirect URL on [your app registration][1].<br>This is usually shown in an error message **Authorization error: InvalidRedirectUrl (2)** |
| 3 | Expired | The application authorization on this tenant has expired |
| 4 | Denied | The applications access to this tenant has been denied |
| 5 | NeedsReapproval | Authorization needs to be re-approved |
| 6 | InvalidTimestamp | The supplied timestamp is invalid |
| 7 | InvalidSignature | Calculated signature is invalid |

## Problems with tokens and certificate

### Error: ID4037

> [!NOTE]
> The key needed to verify the signature could not be resolved from the following security key identifier 'SecurityKeyIdentifier'.

**Problem:**

The certificate is not found:

* the certificates are not installed on the local machine, or
* the certificates are not configured to load the *SuperOfficeFederatedLogin.crt* certificate by using the `CertificateFileCertificateStoreTokenResolver` class

**Resolution:**

1. Check the online certificates are installed on the local machine.
2. Use the `CertificateFileCertificateStoreTokenResolver` to point to the location of the *SuperOfficeFederatedLogin.crt* certificate. Set the `CertificateValidator` to *X509.CertificateValidator.None*.

```csharp
var tokenHandler = new SuperIdTokenHandler();

tokenHandler.IssuerTokenResolver = 
    new SuperOffice.SuperID.Client.Tokens.CertificateFileCertificateStoreTokenResolver(
    System.Web.HttpContext.Current.Server.MapPath("~/App*Data")
    );

tokenHandler.CertificateValidator = System.IdentityModel.Selectors.X509CertificateValidator.None;

return tokenHandler.ValidateToken(returnedToken, TokenType.Saml);
```

### Error: ID4175

> [!NOTE]
> The issuer of the security token was not recognized by the IssuerNameRegistry.

**Problem:**

The **SuperIdCertificate** appSetting value doesn't correlate to an installed certificate.

**Resolution:**

1. [Install the correct certificates][2] for the correct environment (SOD, Stage, Production) into the local certificate store.
2. Make sure the thumbprint is correct: use the arrow keys or **Backspace** to verify that there is no hidden character before the thumbprint value.

Alternatively, override the `IssuerTokenResolver` and set the `CertificateValidator` to *X509CertificateValidator.None*.

### Error: ID4148

> [!NOTE]
> The Saml2SecurityToken is rejected because the SAML2:Assertion's NotOnOrAfter condition is not satisfied.

**Problem:**

Too much time has elapsed since the system user token was signed and sent to exchange for a system user ticket. The returned token containing the system user ticket has expired.

**Resolution:**

Tokens must be validated immediately after they are returned by SuperID.

### Error: Data at the root level is invalid. Line 1, position 1

**Problem:**

**TokenHandler** attempted to validate a JWT token with the SAML token enumeration.

**Resolution:**

Change the enumeration from SAML to JWT.

```csharp
tokenHandler.ValidateToken(token, SuperOffice.SuperID.Contracts.SystemUser.V1.TokenType.Jwt)
```

### Error: IDX10708

> [!NOTE]
> System.IdentityModel.Tokens.JwtSecurityTokenHandler cannot read this string: `PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0idX...shortened for brevity...W9uIElEPSJfZWQ4O`

**Problem:**

**TokenHandler** attempted to validate a SAML token with the Jwt token enumeration.

**Resolution:**

* Don't set the `tokenHandler.JwtIssuerSigningCertificate` property if you use locally installed certificates.
* Don't set `tokenHandler.IssuerTokenResolver` to a new `CertificateFileCertificateStoreTokenResolver` instance if you use a relative certificate file.
* Change the `TokenType` enumeration from *Jwt* to *SAML* in the `Validate` method.

```csharp
//Disable looking up the certificate PeerTrust when using CertificateFileCertificateStoreTokenResolver or JWT tokens.
tokenHandler.CertificateValidator = System.IdentityModel.Selectors.X509CertificateValidator.None;

//Determine what class will lookup the certificates for validation
tokenHandler.IssuerTokenResolver = new SuperOffice.SuperID.Client.Tokens.CertificateFileCertificateStoreTokenResolver(
HttpContext.Current.Server.MapPath("~/App*Data"));

tokenHandler.ValidateToken(token, SuperOffice.SuperID.Contracts.SystemUser.V1.TokenType.Saml)
```

### Error: Value cannot be null. Parameter name: certificate

**Possible problem 1:**

**TokenHandler** attempted to validate a SAML token with the Jwt token enumeration.

**Resolution 1:**

Change the enumeration from Jwt to SAML.

```csharp
tokenHandler.ValidateToken(token, SuperOffice.SuperID.Contracts.SystemUser.V1.TokenType.Saml)
```

**Possible problem 2:**

Certificates have not been installed on the partner's server. When setting up a database mirroring service an email with the following error will be sent to the technical contact:

> [!NOTE]
> Exception:
>
> Failed validating token at at SuperOffice.SuperID.Client.Tokens.SuperIdTokenHandler.ValidateJwtToken(String token, ClaimsPrincipal& claimsPrincipal) in ...
>
> at SuperOffice.Online.Mirroring.MirroringClientService.ValidateSuperOfficeSignedToken(String token) in ...
>
> at SuperOffice.Online.Mirroring.MirroringClientService.Authenticate(AuthenticateRequest request) in ...
>
> Value cannot be null. Parameter name: certificate at at Microsoft.IdentityModel.Tokens.X509SecurityKey..ctor(X509Certificate2 certificate) in ...

**Resolution:**

[Install the public SuperOffice certificates][2]

### Error: Cannot locate PartnerHttpContext

**Problem:**

The web application *web.config* file declared a [session mode][3] equal to `PartnerHttpContext`, but that class is not included in the project or an assembly located in the website's *bin* folder.

**Resolution:**

Ensure your web project contains the following files from the sample project `SuperOffice.DevNet.Online.Login`:

* ContextInitializer.cs
* ContextResolver.cs
* PartnerHttpContext.cs

<!-- Referenced links -->
[1]: https://community.superoffice.com/change-application
[2]: ../certificates/configure.md
[3]: ../../../netserver/config/data.md#session
