---
uid: dp-register-empty-app-config
title: Register a empty app config
description: Registering a new web app in the SuperOffice Developer Portal.
keywords: Developer Portal, app
author: Margrethe Romnes
date: 02.26.2025
version: 2.0
version_devportal: 2.0
topic: howto
envir: cloud
---

# Register a blank app config

## About this template

This template creates an app configuration where you just need to add in the application name and technical contact. For the advanced user who know what they want to configure and where our other templates do not really fit the need.

* Enables the [WebApi][1] and [Services88][16] API endpoints
* Enables access to the [Webhooks agent][15]

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

## What would you like to do next?

* [Get overview of all config sections][1]
* [Check what your client ID is][7]
* [Create a new client secret][8]
* [View or change CORS and redirection URLs][9]
* [Add a certificate][4]
* [Manage notifications][18]
* [Get error emails][13]
* [Start working on the App Store information][11]
* [Request to publish the configuration][2]

<!-- Referenced links -->
[1]: config/app-config.md
[7]: config/find-clientid.md
[8]: config/get-client-secret.md
[9]: config/cors-and-redirection-urls.md
[4]: config/new-certificate.md
[2]: request-to-publish.md
[11]: ../standard-app/app-store/update-app-page.md
[18]: ../best-practices/tenant-status/get-notifications.md
[13]: ../best-practices/error-emails.md
[15]: ../../api/reference/restful/agent/Webhook_Agent/index.md
[16]: ../../api/reference/soap/Services88/index.md

<!-- Referenced images -->
[img5]: media/select-technical-contact.png
