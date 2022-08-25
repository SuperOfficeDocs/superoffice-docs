---
title: Application configuration
uid: dp-app-config
description: Reference of application configuration in the SuperOffice Developer Portal.
author: Bergfrid Dias
so.date: 08.25.2022
keywords: apps, Developer Portal, authentication
so.topic: reference
so.version:
so.envir: cloud
so.client:
---

# Application configuration

## Authentication

| Setting | Description | How-tos | Read more |
|---|---|---|---|
| Is native or mobile app | Type if application. OAuth2 Native App flow if checked. | [Create native app][20] | [OAuth2 Native app flow][21] |
| Client ID | Uniquely identifies the application. | [Find client ID][16] | [Terminology][8] |
| Allowed redirect URLs | Context-specific URLs that will be called by the browser after successful sign-in or when a user clicks one of the available buttons on your application entry. | [Add or update][18] | [About redirects and CORS][7] |
| Allowed postlogout redirect URLs | Context-specific URLs that will be called by the browser after successful sign-out a user.| [Add or update][18] | [Endpoint types][22] |
| CORS URLs | | [Add or update][18] | [About redirects and CORS][7] |
| Default redirect URL | Used by legacy authentication - add all needed redirect URLs to your apps allowed list. | [Add or update][18] | [Endpoint types][22] |

> [!NOTE]
> Redirection and CORS URLs must be listed one per line.

## Secrets and certificates

| Setting | Description | How-tos | Read more |
|---|---|---|---|
| Client secret | The application token (password). Must be supplied when invoking any of the SuperOffice CRM Online web services. | [Create new client secret][17] | [Terminology][8] |
| Certificates | RSA encryption keys | [Create new certificate][19], [Sign system user token][9] | [SuperID certificates][24] |

## Endpoints

| Setting | Description | How-tos | Read more |
|---|---|---|---|
| Supported endpoints | Endpoints the application can connect to. | [Update endpoints][23] | [What API to use][10] |

## Notifications

SuperOffice provide the capability to either push or pull tenants status, this is where you provide a public endpoint we may push changes to.

| Setting | Description | How-tos | Read more |
|---|---|---|---|
| Customer state change endpoint | URL SuperOffice can push notifications to you when a tenant change status (on/off) | [Manage notifications][14] | [About tenant status][11] |
| Send error emails to technical contact | If checked, the person listed as technical contact for the app will receive error emails. | [Get error emails][14] | [About tenant status][11] |

## Integrations

| Setting | Description | How-tos | Read more |
|---|---|---|---|
| ERP sync | For integration with an ERP system. | [Create sync app][26] | [ERP connector API][28] |
| Quote connector | | [Create sync app][26] | [Quote connector API][27] |
| Mirroring | For local processing when real-time data is not the most important consideration. | [Create mirror app][26] | [About mirroring][12] |

For each of the above:

* Endpoint URL, on/off
* Send error emails to technical contact

## License

[!include[Can be changed by SO only](../includes/note-changing-licenses.md)]

| Setting | Description | How-tos | Read more |
|---|---|---|---|
| Required licenses | The licenses this application needs. | | [About licenses][13] |
| Granted licenses | The licenses included. | | [About licenses][13] |

* Custom apps
* Integration server
* Database mirroring
* Expander services

Standard ERP Sync applications may be granted Integration Server so the ERP Sync panel in the customers admin is activated.

## Advanced

These settings are read only for all except SuperOffice AS app managers.

| Setting | Description |
|---|---|
| Supports multi-tenant identity | Only internal |
| Allow redirection to partner application for suspended customers | Only internal |
| Access to (claims) | Returned in the JWT as claims - for server-to-server apps we tick SystemToken |
| Access to (agents) | These agents are restricted in our Online environment. A custom app may get access to CRMScript agent. |
| Custom error URL | Where users are sent if the sign-in is unsuccessful. |
| Custom claims | In addition to the [SuperOffice claims][32]. |
| Exclude from invoice | Only internal |

**Claims:**

* internalnetserverurl
* system token
* person ID
* feature toggles
* minimum pocket version

**Agents:**

* user
* erpsync
* replication
* email
* messaging
* maillink
* webhook
* CRMScript
* data
* AI
* pocket
* dash

## Verification

| Setting | Description | How-tos | Read more |
|---|---|---|---|
| Authorization level | All apps will get **Administrator** by default in SOD. Custom applications will be changed to **Explicit** when published to production. | [Request to publish][31] | |
| Security audit | Workflow status. | [Passing the audit][29] | [About Watchcom initial security evaluation][6] |
| Certified | Workflow status. | [Steps to certification][5] | [About certification][30] ,[Certification checklist][5] |

## See also

* [Application settings][1]
* [Partner settings][3]
* [User settings][4]

<!-- Referenced links -->
[1]: app-settings.md
[3]: partner-settings.md
[4]: user-settings.md
[5]: ../../apps/certification/certify-app.md
[6]: ../../apps/certification/initial-watchcom-eval.md
[7]: ../../apps/redirects/index.md
[8]: ../../apps/terminology.md
[9]: ../../api//authentication/online/auth-application/sign-system-user-token.md
[10]: ../../apps/getting-started/what-api-to-use.md
[11]: ../../apps/tenant-status/index.md
[12]: ../../mirroring/index.yml
[13]: ../../admin/license/index.md
[14]: ../howto/notifications.md
[16]: ../security/find-clientid.md
[17]: ../security/get-client-secret.md
[18]: ../security/cors-and-redirection-urls.md
[19]: ../security/new-certificate.md
[20]: ../create-app/native-app.md
[21]: ../../api/authentication/online/sign-in-user/auth-code-flow.md
[22]: ../../apps/redirects/endpoint-types.md
[23]: ../howto/update-endpoints.md
[24]: ../../api/authentication/online/certificates/index.md
[25]: ../create-app/mirror-app.md
[26]: ../create-app/sync-app.md
[27]: ../../api/plugins/quote-connectors/index.md
[28]: ../../api/plugins/erp-connectors/index.md
[29]: ../../apps/certification/secure-app.md
[30]: ../../apps/certification/index.md
[31]: ../howto/request-to-publish.md
[32]: ../../api/authentication/online/validate-security-tokens.md#superoffice-specific-claims

<!-- Referenced images -->
