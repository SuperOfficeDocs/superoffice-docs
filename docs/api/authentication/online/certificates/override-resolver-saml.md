---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: override_resolver_saml       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: How to override the certificate resolver for legacy SAML tokens # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto                # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# How to override the certificate resolver for legacy SAML tokens

This code allows the certificate routines to bypass certificate validation, and directly validate the **SAML** security token with the provided certificate. This is no longer the preferred method.

We recommend that you use [JWT security tokens][1].

This override short-circuits the PeerTrust validation, or certificate dependencies, by setting the `CertificateValidator` property to **None**.

```csharp
tokenHandler.CertificateValidator = X509CertificateValidator.None;
```

**Pre-requisites:**

* Your application has an *App\*Data* folder containing the *SuperOfficeFederatedLogin.crt* certificate.
* `CertificateValidator` property is set to *None*.

For SAML tokens, the application must override the `IssueTokenResolver` property with a class that knows how to resolve certificates.

SuperOffice provides the `CertificateFileCertificateStoreTokenResolver` class. Its constructor accepts a path where it will search for certificates with a .crt, .cer, or .pfx file extension.

```csharp
public SuperIdToken ValidateToken(string token)
{
  var tokenHandler = new SuperIdTokenHandler();
```

The `ValidateToken` method will return a [SuperIdToken][2] populated with all the claims returned by SuperOffice CRM Online.

This operation will fail if the token is not SAML or if the certificate is missing.

<!-- Referenced links -->
[1]: override-resolver.md
[2]: ../superid-token.md