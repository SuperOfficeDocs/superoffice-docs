---
uid: security-requirements
title: Security requirements
description: Security requirements
keywords: certification
author: Margrethe Romnes, Tony Yates
date: 03.22.2024
topic: reference
envir: cloud
client: online
---

# Security requirements

It is paramount that you keep data secure. Security is our topmost concern.

If needed, we may go back in time to see when and by whom an operation was performed.

## Requirements

* [Standard applications][1] must pass [certification by SuperOffice][2].
* Standard applications must pass a [security audit by Watchcom][3].
* All red flags reported by Watchcom must be fixed before the application is published as a [beta][4].
* [Custom applications][5] must pass [validation by SuperOffice][6]

### Credentials and authentication

* The application must use [federated authentication][17]. Applications must ensure the quality of service is not jeopardized for any of our customers.
* Web panels added by the application must authorize the user before any data is shown (seamless single sign-on)
* Use SuperID and a system user; don't send username and password.
* Ensure all cookies have the **HttpOnly** flag set, setting **secure** is recommended.
* Partner applications are not allowed to store any user credential authentication information.
  * Setting **ConfigFile.Services.ApplicationToken** in code is forbidden.
* You must change all default passwords before deploying the application to the production environment.
* Use multi-factor authentication and encrypted channels for all administrative account access.
* If your [client secret][9] (application token) should be compromised, you must notify SuperOffice Online Operations as soon as possible (submit form).

### Data access

* Use the SuperOffice APIs to read from and write to the database to ensure data consistency.
* Ensure **role, group, and user permissions** are adhered to.
  * Ensure that **sentry rules** are followed.
  * Give the user feedback when sentry denies access.
  * Using the web services in the application user's context will ensure this happens automatically, however, be aware when running in [system user context][10].
* Use the existing **Preference tables**, **ForeignKey, ForeignDevice, ForeignApp tables** to store extra information. If you need more tables, they must be hosted in your cloud.

### Endpoints and application environment

* You must specify a secure [redirect URL][11].
  * Run the redirect URL through Qualys SSL Labs, SSL Server tests, and aim for an A.
  * You must support TLS 1.2. You may support TLS 1.3.
  * We will not accept any sites where SSL 2.0 or 3.0 is supported.
* Any code must run with SSL in your cloud.
  * We will not host any partner application on `online.superoffice.com`.
  * SuperOffice CRM Online requires that all applications support a secure SSL environment.
* Maintain separate environments for production and non-production systems (development). Developers should not have unmonitored access to production environments.

### Logging

* Ensure that local logging has been enabled on all systems and networking devices where you host your application.
* Logs should be detailed and include info such as event source, date, user, timestamp, source addresses, destination addresses.
* Logs should be minimum kept for 3 months.
  * Ensure that all systems that store logs have adequate storage space for the logs generated.
* Regularly review logs to identify anomalies or abnormal events.

## Guidance

* We recommend you also have a [staging environment][12].
* Always keep in mind the [OWASP top ten list][13].
* Center for Internet Security Controls [CIS controls list][14]

<!-- Referenced links -->
[1]: ../index.md
[2]: ../certification/certify-app.md
[3]: ../certification/initial-watchcom-eval.md
[4]: ../publish.md#beta
[5]: ../../custom-app/index.md
[6]: ../../custom-app/validate.md
[11]: ../../create-app/config/redirects.md
[9]: ../../getting-started/index.md#client-secret
[10]: ../../getting-started/user-contexts.md
[12]: ../../getting-started/app-envir.md
[17]: ../../../identity-management/federated-auth.md
[13]: https://www.owasp.org/index.php/Category:OWASP_Top_Ten_Project
[14]: https://www.cisecurity.org/controls/cis-controls-list/
