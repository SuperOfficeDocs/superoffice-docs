---

uid: validate_security_tokens
title: Validate security tokens
description: How to validate security tokens
author: {github-id}
keywords: certificates, jwt
so.topic: howto
so.envir: cloud
so.client: online
---

# How to validate security tokens

Security token validation is an important step to ensure the token has not been compromised between SuperOffice sending it and you receiving it.

There are a few cases when validation is required:

1. Validate the `id_token` issued during OpenID Connect authentication.
2. Validate the token returned from System-User flow.
3. Validate the token returned from the legacy application login (pre-OpenID Connect support).

Performing validation is a straight-forward process that, validating a response that was signed by SuperOffice with a private certificate, only requires the public SuperOffice certificate.

There are a couple of options to perform the actual validation:

1. Orchestrate the validation code yourself.
    * May or may not require physical SuperOffice certificates, i.e. can use the [OpenID Connect metadata endpoint][8] to get the required information.

2. Use [SuperOffice.Online.Core][6] NuGet package for .NET Framework
    * This required SuperOffice certificates.

3. Use [SuperOffice.WebApi][9] NuGet package written for .NET Standard 2.0
    * This uses the [OpenID Connect metadata endpoint][8].

## Using SuperOffice.WebApi

This NuGet package contains 2 validation classes, one for each of the 2 main validation case:

* OpenID Connect validation: `JwtTokenHandler`
* SystemUser Flow validation: `SystemUserTokenHandler`

There are 2 different token handlers because they do have slightly different implementations. The main difference is that the OpenID Connect `ValidationParameters.ValidAudience` uses the applications client_id parameter, and the SystemUser's `ValidationParameters.ValidAudience` is the database serial number. The latter requires additional processing to extract the database serial number from the token.

```csharp
var tokenHandler = new JwtTokenHandler(clientId, httpClient, onlineEnvironment);
TokenValidationResult result = await tokenHandler.ValidateAsync("{id_token}");

```

```csharp
var tokenHandler = new SystemUserTokenHandler(httpClient, onlineEnvironment);
TokenValidationResult result = await tokenHandler.ValidateAsync("{system_user_result}");

```

## Using SuperOffice.Online.Core

Lets' take a look at what the simplest possible security token validation might look like.

All security token responses are Base64 encoded strings of either a [JWT][2] or legacy [SAML][1] token. We **strongly recommend that you use JWT** tokens and not SAML!

The main class for processing tokens is `SuperIdTokenHandler` in the *SuperOffice.SuperID.Client* DLL.

> [!NOTE]
> If you don't have access to the certificate store, you must substitute this procedure with a [validation override][3].

### Pre-requisites

* All [3 certificates][4] are installed correctly.
* A correct thumbprint is defined in the **SuperIdCertificate** appSettings section.

### Procedure

1. Decode the token from Base64 to a string. This results in a JSON string.

2. Use an appropriate certificate validation library and the public SuperOffice certificate to validate the token:

    1. Instantiate a `SuperIdTokenHandler`.
    2. Invoke the `ValidateToken` method and pass a JWT token.

3. If and only if the token is valid, accept the claims and proceed accordingly:

    * Receive a **SuperIdToken** populated with the resulting claims.

```csharp
public SuperIdToken ValidateToken(string token)
{
    var tokenHandler = new SuperIdTokenHandler();
    return tokenHandler.ValidateToken(token, TokenType.Jwt);
}
```

If you for some reason need to use SAML tokens, simply substitute token type in step 2 (`TokenType.Saml`) and pass your SAML token. `SuperIdTokenHandler` hides the slight differences between SAML and JWT tokens.

## SuperIdToken

The `SuperIdToken` is a container for security claims. It is returned after validation of a JWT (or SAML) token and can be used for future authentication.

> [!CAUTION]
> This legacy class pertains to our [old form][11] of authentication. [Use OpenID Connect][12].

`SuperIdToken` contains:

* individual properties for common claims
* a complete list of [claims][9] returned by SuperOffice CRM Online

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

* **Ticket:** a SuperOffice ticket, representing the current user credential on this particular customer; not included in [OAuth flows][14]

* **NetServer_URL:** the SOAP web service endpoint for the current customer site

* **WebAPI_URL:** the RESTful endpoints for the current customer site (replaces `NetServer_URL` in class `SuperIdToken`)

* **Email:** the current user’s email address

* **ContextIdentifier (CTX):** context value (current customer ID).

* **System User Token:** a string used to exchange for a system user ticket credential

The **SuperIdToken** data type is located in the `SuperOffice.SuperID.Client.Tokens` namespace in the SuperOffice.Online.Core assembly.

## Assemblies and helper libraries

SuperOffice provides the [SuperOffice.Crm.Online.Core][6] NuGet for processing online requests. It contains the following assemblies:

* SuperOffice.Online.Core
* SuperOffice.SuperID.Client
* SuperOffice.SuperID.Contracts

We also provide [.NET helper libraries][7], which you can download.

<!-- Referenced links -->
[1]: http://saml.xml.org/saml-specifications
[2]: https://tools.ietf.org/html/rfc7519
[3]: certificates/override-resolver.md
[4]: certificates/index.md
[6]: https://www.nuget.org/packages/SuperOffice.Crm.Online.Core
[7]: ../../assets/downloads.md
[8]: api.md
[9]: https://www.nuget.org/packages/SuperOffice.WebApi
[11]: sign-in-user/auth-user-legacy.md
[12]: sign-in-user/auth-user.md
[14]: index.md
