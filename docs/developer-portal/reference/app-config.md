---
title: Application configuration
uid: dp-app-config
description: Reference of application configuration in the SuperOffice Developer Portal.
author: Bergfrid Dias
so.date: 04.25.2022
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
| Is native or mobile app | Type if application. | | |
| Client ID | Uniquely identifies the application. | [Find client ID][16] | [Terminology][8] |
| Allowed redirect URLs | Context-specific URLs that will be called by the browser after successful sign-in or when a user clicks one of the available buttons on your application entry. | [Add or update][18] | [About redirects and CORS][7] |
| Allowed postlogout redirect URLs | | [Add or update][18] | |
| CORS URLs | | [Add or update][18] | |
| Default redirect URL | | [Add or update][18] | |

> [!NOTE]
> Redirection and CORS URLs must be listed one per line.

## Secrets and certificates

| Setting | Description | How-tos | Read more |
|---|---|---|---|
| Client secret | The application token (password). Must be supplied when invoking any of the SuperOffice CRM Online web services. | [Create new client secret][17] | [Terminology][8] |
| Certificates | RSA encryption keys | [Create new certificate][19]<br/>[Sign system user token][9] | |

## Endpoints

| Setting | Description | How-tos | Read more |
|---|---|---|---|
| Supported endpoints | Endpoints the application can connect to. | | [What API to use][10] |

## Notifications

SuperOffice provide the capability to either push or pull tenants status, this is where you provide a public endpoint we may push changes to.

| Setting | Description | How-tos | Read more |
|---|---|---|---|
| Customer state change endpoint | URL SuperOffice can push notifications to you when a tenant change status (on/off) | [Manage notifications][14] | [About tenant status][11] |
| Send error emails to technical contact | If checked, the person listed as technical contact for the app will receive error emails. Enabled by default. | [Get error emails][15] | |

## Integrations

| Setting | Description | How-tos | Read more |
|---|---|---|---|
| ERP sync | | | |
| Quote connector | | | |
| Mirroring | | | [About mirroring][12] |

For each of the above:

* Endpoint URL, on/off
* Send error emails to technical contact

## License

[!include[Can be changed by SO only](../includes/note-changing-licenses.md)]

| Setting | Description | How-tos | Read more |
|---|---|---|---|
| Required licenses | The licenses this application needs. | | [About licenses][13] |
| Granted licenses | | | |

* Custom apps
* Integration server
* Database mirroring
* Expander services

Standard ERP Sync applications may be granted Integration Server so the ERP Sync panel in the customers admin is activated.

## Advanced

| Setting | Description | How-tos | Read more |
|---|---|---|---|
| Supports multi-tenant identity | | | |
| Allow redirection to partner application for suspended customers | | | |
| Access to (claims) | | | |
| Access to (agents) | | | |
| Custom error URL | | | |
| Custom claims | | | |
| Exclude from invoice | | | |

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
| Authorization level | | | |
| Security audit | Workflow status. | | [About Watchcom initial security evaluation][6] |
| Certified | Workflow status. | | [About certification][5] |

## See also

* [Application settings][1]
* [Company settings][3]
* [User settings][4]

<!-- Referenced links -->
[1]: app-settings.md
[3]: company-settings.md
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
[15]: ../howto/get-error-emails.md
[16]: ../security/find-clientid.md
[17]: ../security/get-client-secret.md
[18]: ../security/cors-and-redirection-urls.md
[19]: ../security/new-certificate.md

<!-- Referenced images -->
