---
title: Register an ERP and quote sync app
uid: dp-register-sync-app
description: Describes how to register a new ERP and quote sync app in the SuperOffice Developer Portal.
author: Bergfrid Dias
so.date: 06.08.2022
keywords: Developer Portal, app, ERP
so.topic: howto
so.version:
so.envir: cloud
so.client:
---

# Register an ERP and quote sync app

## About this template

This template creates an app configuration for a standard app and asks for the ERP Sync and Quote endpoint URLs. These may also be added at a later time under **Advanced - ERP** in the application configuration.

* Enables the [WebApi][1] and [Services88][6] API endpoints
* Enable access to the [SystemToken claim][12]
* Enables access to the [ERPSync agent][5] and [Webhook agent][4]

## Standard app granted license

*Integration server* under licenses so the Sync / Quote panel is active in customer's Settings and Maintenance.

## Create app

1. In the Developer Portal, go to your partner page.

2. In the **Applications** section, click **Create App**.

3. Choose the **Standard ERP sync and quote app** template. Click **Next**.

4. Enter the name of your application. Click **Next**.

    [!include[Requirements for app name](includes/note-app-name.md)]

5. Enter the URL of the integration endpoints.

    Click On/Off to activate the endpoint.

    > [!NOTE]
    > If the endpoint is not yet ready, you may change configuration later.

    ![Mirroring service URL -screenshot][img1]

6. [!include[ALT](includes/set-technical-contact.md)]

    ![Developer Portal set technical contact when creating app -screenshot][img5]

7. Click **Create Application**.

## What would you like to do next?

* [Check what your client ID is][7]
* [Create a new client secret][8]
* [View or change CORS and redirection URLs][9]
* [Add a certificate][10]
* [Manage notifications][2]
* [Get error emails][2]
* [Start working on the App Store information][11]
* [Request to publish the configuration][18]

<!-- Referenced links -->
[1]: ../../api/reference/restful/index.md
[2]: ../howto/notifications.md
[4]: ../../api/reference/restful/agent/Webhook_Agent/index.md
[5]: ../../api/reference/restful/agent/ErpSync_Agent/index.md
[6]: ../../api/reference/soap/Services88/index.md
[7]: ../security/find-clientid.md
[8]: ../security/get-client-secret.md
[9]: ../security/cors-and-redirection-urls.md
[10]: ../security/new-certificate.md
[11]: ../app-store/update-app-page.md
[12]: ../../api/authentication/online/index.md#claims-and-scope
[18]: ../howto/request-to-publish.md

<!-- Referenced images -->
[img1]: media/erp-integration-points.png
[img5]: media/select-technical-contact.png
