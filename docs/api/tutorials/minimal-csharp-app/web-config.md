---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: minimal_csharp_app_web_config       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Web.Config configuration overview # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic:                       # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Web.Config configuration overview

This section will present the technical details to understand what is required to get the example running on your machine. This section also explains how the example application works.

**Key sections:**

* SuperOffice>Data>Session
* SuperOffice>Service
* appSettings

[!include[web.config](./includes/web-config.md)]

The `Session Mode` property instructs NetServer to use the **PartnerHttpContext** provider to store the user's context when the application is run.

## SuperOffice Services

### DefaultMode

Must be *Remote* to work with SuperOffice Online web services.

### ApplicationToken

Must be set to identify partner applications. Online services will reject unidentified callers.

* This property is expected and used by the NetServer proxy assemblies.
* The token is exchanged only after a secured HTTP connection has been established.

[Application credentials][1] are environment-specific. The value of **ApplicationToken** will be different in SOD and production.

## appSettings

### SoAuthCookie

An identity used when persisting a Cookie.

### SoAppId

A public application identifier.

It is used by the `AuthenticationHelper` class and is appended to the URL used when forwarding your application to the SoFederationGateway URL (also defined in **AppSettings**).

The **SoAppId** appears in the browser's address bar when forwarded to SuperID and is vulnerable to man-in-the-middle attacks. However, you can mitigate this threat by validating tokens after each successful authentication.

The SoAppId is relevant when a new user attempts to access your partner application for the first time. That user will be prompted to allow your application to run within the user's context. This consent feature also enables a partner to revoke access if necessary. Although inaccessible to partners today, this feature will be made accessible in the future.

Application credentials are environment-specific. The value of SoAppId will be different in SOD and production.

### SoFederationGateway

Specifies the URL where SuperID resides.

SuperID is environment-specific. The value of **SoFederationGateway** will be different in SOD and production.

* **SOD:** `https://sod.superoffice.com`
* **Production:** `https://online.superoffice.com/login/`

### SystemTokenCertificatePath

Path to a local file containing the partners' **application private key**.

**Example private key file:**

[!include[ALT](./includes/private-key.md)]

### SuperIdCertificate

The certificate thumbprint identifier on the machine hosting the website. The thumbprint is used by the `SuperIdTokenHandler` class to verifying the JWT token returned by SuperID to the partner web application.

The thumbprint identifier is environment-specific. The value of `SuperIdCertificate` will be different in SOD and production.

<!-- Referenced links -->
[1]: ../../apps/client-id-secret.md
