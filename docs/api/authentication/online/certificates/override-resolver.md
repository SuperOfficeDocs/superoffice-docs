---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: override_certificate_resolver       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: How to override the certificate resolver # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto               # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# How to override the certificate resolver

To override the default behavior of JWT security token validation is required when you deploy your application in a restricted environment where you have no access to the certificate store. This is the case **when you deploy to a cloud application server**.

When you override the [security token validation routine][1], you need only 1 certificate, *SuperOfficeFederatedLogin.crt*. If you use the default PeerTrust validation, you need [all 3 certificates][2].

This override short-circuits the PeerTrust validation, or certificate dependencies, by setting the **CertificateValidator** property to `None`.

`tokenHandler.CertificateValidator = X509CertificateValidator.None;`

This allows the certificate routines to bypass certificate validation, and directly validate the JWT security token with the provided certificate.

**Pre-requisites:**

* Your application has an *App\_Data* folder containing the *SuperOfficeFederatedLogin.crt* certificate.
* `CertificateValidator` property is set to **None**.
* The certificate type must be **X509Certificate2**.

For JWT security tokens, the application must override the `JwtIssuerSigningCertificate` property.

The  X509Certificate2 constructor accepts a file name argument and is the file name of the certificate that will be used to validate the security token.

The full path to the  *App\_Data* folder containing *SuperOfficeFederatedLogin.crt* is passed to the constructor.

[!code-csharp[ValidateToken()](includes/validate-token.cs)]

The `ValidateToken` method will return a [SuperIdToken][3] populated with all the claims returned by SuperOffice CRM Online.

This operation will fail if the token is not JWT or if the certificate is missing.

<!-- Referenced links -->
[1]: validate-security-tokens.md
[2]: index.md
[3]: ../superid-token.md