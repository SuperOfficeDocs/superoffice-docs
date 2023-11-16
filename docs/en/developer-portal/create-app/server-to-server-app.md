---
title: Register a server-to-server app
uid: dp-register-server-to-server-app
description: Registering a new server-to-server app in the SuperOffice Developer Portal.
author: Bergfrid Dias
so.date: 11.15.2023
keywords: Developer Portal, app, server-to-server, system user
so.topic: howto
so.version:
so.dp-version: 1.16
so.envir: cloud
so.client:
---

# Register a server-to-server app

## About this template

This template creates an app configuration that uses the [system user flow][7].

* Enables the [WebApi][1] and [Services88][6] API endpoints
* Enables access to the [SystemToken claim][5]
* Enables access to the [Webhook agent][4]

[!include[Required license](includes/cust-app-req-license.md)]

## Create app

1. In the Developer Portal, go to your partner page.

2. In the **Applications** section, click **Create App**.

3. Choose the **server-to-server** template. Then select whether this is a custom or standard app. Click **Next**.

4. Enter the name of your application. Click **Next**.

    [!include[Requirements for app name](includes/note-app-name.md)]

5. Optionally, click **Add More** to enter additional URLs. Then click **Next**.

    ![Enter redirect URL -screenshot][img4]

6. [!include[ALT](includes/set-technical-contact.md)]

    ![Developer Portal set technical contact when creating app -screenshot][img5]

7. Click **Create Application**.

## What would you like to do next?

* [Check what your client ID is][12]
* [Create a new client secret][18]
* [View or change CORS and redirection URLs][13]
* [Add a certificate][10]
* [Manage notifications][2]
* [Get error emails][3]
* [Start working on the App Store information][9]
* [Request to publish the configuration][11]

<!-- Referenced links -->
[2]: ../best-practices/tenant-status/get-notifications.md
[3]: ../best-practices/error-emails.md
[9]: ../standard-app/app-store/update-app-page.md
[1]: ../../api/reference/restful/index.md
[4]: ../../api/reference/restful/agent/Webhook_Agent/index.md
[5]: ../../api/authentication/online/index.md#claims-and-scope
[6]: ../../api/reference/soap/Services88/index.md
[7]: ../../api/authentication/online/auth-application/index.md
[12]: config/find-clientid.md
[18]: config/get-client-secret.md
[13]: config/cors-and-redirection-urls.md
[10]: config/new-certificate.md
[11]: request-to-publish.md

<!-- Referenced images -->
[img4]: media/enter-redirect-urls.png
[img5]: media/select-technical-contact.png
