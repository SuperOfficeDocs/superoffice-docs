---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: validate_security_tokens       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: How to validate JWT security tokens # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: certificates,jwt
so.topic: howto           # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# How to validate JWT security tokens

Lets' take a look at what the simplest possible security token validation might look like.

All security token responses are Base64 encoded strings of either a [SAML][1] or [JWT][2] token. We **strongly recommend that you use JWT** tokens and not SAML!

The main class for processing tokens is `SuperIdTokenHandler` in the *SuperOffice.SuperID.Client* DLL.

> [!NOTE]
> If you don't have access to the certificate store, you must substitute this procedure with a [validation override][3].

## Pre-requisites

* All [3 certificates][4] are installed correctly
* A correct thumbprint is defined in the **SuperIdCertificate** appSettings section

## Procedure

1. Decode the token from Base64 to a string. This results in a JSON string.

2. Use an appropriate certificate validation library and the public SuperOffice certificate to validate the token:

    1. Instantiate a `SuperIdTokenHandler`
    2. Invoke the `ValidateToken` method and pass a JWT token

3. If and only if the token is valid, accept the claims and proceed accordingly:

    * Receive a [SuperIdToken][5] populated with the resulting claims

```csharp
public SuperIdToken ValidateToken(string token)
{
    var tokenHandler = new SuperIdTokenHandler();
    return tokenHandler.ValidateToken(token, TokenType.Jwt);
}
```

If you for some reason need to use SAML tokens, simply substitute token type in step 2 (`TokenType.Saml`) and pass your SAML token. `SuperIdTokenHandler` hides the slight differences between SAML and JWT tokens.

## Assemblies and helper libraries

SuperOffice provides the [SuperOffice.Crm.Online.Core][6] NuGet for processing online requests. It contains the following assemblies:

*SuperOffice.Online.Core
*SuperOffice.SuperID.Client
*SuperOffice.SuperID.Contracts

We also provide [.NET helper libraries][7], which you can download.

<!-- Referenced links -->
[1]: http://saml.xml.org/saml-specifications
[2]: https://tools.ietf.org/html/rfc7519
[3]: override-resolver.md
[4]: index.md
[5]: ../superid-token.md
[6]: https://www.nuget.org/packages/SuperOffice.Crm.Online.Core
[7]: ../../../assets/downloads.md
