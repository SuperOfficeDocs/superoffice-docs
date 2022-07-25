---
title: Register a empty app config
uid: dp-register-empty-app-config
description: Registering a new web app in the SuperOffice Developer Portal.
author: Margrethe Romnes
so.date: 06.08.2022
keywords: Developer Portal, app
so.topic: howto
so.version:
so.envir: cloud
so.client:
---

# Register a blank app config

## About this template

This template creates an app configuration where you just need to add in the application name and technical contact. For the advanced user who know what they want to configure and where our other templates do not really fit the need.

* Enables the [WebApi][1] and [Services88][6] API endpoints
* Enables access to the [Webhooks agent][5]

[!include[Required license](includes/cust-app-req-license.md)]

> [!NOTE]
> If the app also take advantage of the database mirroring capability, then the database mirroring subscription is required as well.

## Create app

1. In the Developer Portal, go to your partner page.

2. In the **Applications** section, click **Create App**.

3. Choose the DIY / **Empty** template. Then select whether this is a custom or standard app. Click **Next**.

4. Enter the name of your application. Click **Next**.

    [!include[Requirements for app name](includes/note-app-name.md)]

5. [!include[ALT](includes/set-technical-contact.md)]

    ![Developer Portal set technical contact when creating app -screenshot][img5]

6. Click **Create Application**.

7. Change to **Advanced** mode if not automatically redirected to this.

## What would you like to do next?

* [Get overview of all config sections][1]
* [Check what your client ID is][7]
* [Create a new client secret][8]
* [View or change CORS and redirection URLs][9]
* [Add a certificate][10]
* [Manage notifications][2]
* [Get error emails][2]
* [Start working on the App Store information][11]
* [Request to publish the configuration][18]

<!-- Referenced links -->
[1]: ../reference/app-config.md
[2]: ../howto/notifications.md
[5]: ../../api/reference/restful/agent/Webhook_Agent/index.md
[6]: ../../api/reference/soap/Services88/index.md
[7]: ../security/find-clientid.md
[8]: ../security/get-client-secret.md
[9]: ../security/cors-and-redirection-urls.md
[10]: ../security/new-certificate.md
[11]: ../app-store/update-app-page.md
[18]: ../howto/request-to-publish.md

<!-- Referenced images -->
[img5]: media/select-technical-contact.png
