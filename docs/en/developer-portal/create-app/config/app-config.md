---
uid: dp-app-config
title: Application configuration
description: Reference of application configuration in the SuperOffice Developer Portal.
keywords: apps, Developer Portal, authentication, integration settings
author: Bergfrid Dias
date: 02.26.2025
version: 2.0
version_devportal: 2.0
topic: reference
envir: cloud
---

# Application configuration

## Authentication

| Setting | Description | How-tos | Read more |
|---|---|---|---|
| Allowed postLogout redirect URLs | Context-specific URLs that will be called by the browser after successful sign-out a user.| [Add or update][18] | [Endpoint types][7] |
| Allowed redirect URLs | Context-specific URLs that will be called by the browser after successful sign-in or when a user clicks one of the available buttons on your application entry. | [Add or update][18] | [About redirects and CORS][7] |
| Authorize | The description shown in the concent dialog when the admin is prompted to approve the application. | [Get consent][34], [Add or update text][35] | [About consent][33] |
| Certificates | RSA encryption keys | [Create new certificate][19], [Sign system user token][9] | [SuperID certificates][24] |
| Client ID | Uniquely identifies the application. | [Find client ID][16] | [Terminology][8] |
| CORS URLs | | [Add or update][18] | [About redirects and CORS][7] |
| Is native or mobile app | Type if application. OAuth2 Native App flow if checked. | [Create native app][20] | [OAuth2 Native app flow][21] |
| Secrets | The application token (password). Must be supplied when invoking any of the SuperOffice CRM Online web services. | [Create new client secret][17] | [Terminology][8] |

> [!NOTE]
> Redirection and CORS URLs must be listed one per line.

## Integration settings

| Setting | Description | How-tos | Read more |
|---|---|---|---|
| Customer state change endpoint | URL SuperOffice can push notifications to you when a tenant change status (off/on) | [Manage notifications][14] | [About tenant status][11] |
| ERP sync | For integration with an ERP system. | [Create sync app][26] | [ERP connector API][28] |
| Mirroring | For local processing when real-time data is not the most important consideration. | [Create mirror app][25] | [About mirroring][12] |
| Quote connector | | [Create sync app][26] | [Quote connector API][27] |

For each of the above:

* Endpoint URL, off/on
* [Send error emails][14]. If checked, the person listed as technical contact for the app will receive error emails.

## Advanced

These settings except "Support dark mode" and "Remove remember me" must be changed by the app manager.

| Setting | Description | How-tos | Read more |
|---|---|---|---|
| Support dark mode | Enables dark mode browser setting for the Online Login page. | | |
| Remove remember me | Whether the **Remember me** checkbox should be visible on the login page. | | |
| Access to (agents) | These agents are restricted in our Online environment. A custom app may get access to CRMScript agent. | | |
| Access to (claims) | Returned in the JWT as claims - for server-to-server apps we tick SystemToken | | |
| Authorization level | All apps will get **Administrator** by default in SOD. Custom applications will be changed to **Explicit** when published to production. | [Request to publish][31] | |
| Custom claims | In addition to the [SuperOffice claims][32]. | | |
| Default redirect URL | Used by legacy authentication - add all needed redirect URLs to your apps allowed list. | [Add or update][18] | [Endpoint types][7] |
| Supported endpoints | Endpoints the application can connect to. | [Update endpoints][23] | [What API to use][10] |

**Claims:**

* InternalNetserverUrl
* SystemToken
* PersonId
* FeatureToggles
* MinimumPocketVersion

**Agents:**

* User
* ErpSync
* Replication
* Email
* Messaging
* MailLink
* Webhook
* CRMScript
* Data
* Ai
* Pocket
* Dash
* DocumentMigration

## See also

* [Application settings][1]
* [Partner settings][3]
* [User settings][4]

<!-- Referenced links -->

[3]: ../../partner/partner-settings.md
[4]: ../../partner/user-settings.md
[1]: ../../standard-app/app-store/app-settings.md
[7]: redirects.md
[8]: ../../getting-started/index.md#terminology
[9]: ../../../api/authentication/online/auth-application/sign-system-user-token.md
[10]: ../../getting-started/what-api-to-use.md
[11]: ../../best-practices/tenant-status/index.md
[12]: ../../../mirroring/index.yml
[14]: ../../best-practices/error-emails.md
[16]: find-clientid.md
[17]: get-client-secret.md
[18]: cors-and-redirection-urls.md
[19]: new-certificate.md
[20]: ../native-app.md
[21]: ../../../api/authentication/online/sign-in-user/auth-code-flow.md
[23]: update-endpoints.md
[24]: ../../../api/authentication/online/certificates/index.md
[25]: ../mirror-app.md
[26]: ../sync-app.md
[27]: ../../../api/plugins/quote-connectors/index.md
[28]: ../../../api/plugins/erp-connectors/index.md
[31]: ../request-to-publish.md
[32]: ../../../api/authentication/online/validate-security-tokens.md#superoffice-specific-claims
[33]: ../../provisioning/consent.md
[34]: ../../provisioning/get-consent.md
[35]: ../../provisioning/update-consent-text.md

<!-- Referenced images -->
