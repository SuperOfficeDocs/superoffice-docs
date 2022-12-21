---
title: Register a mirroring app
uid: dp-register-mirroring-app
description: Registering a new mirroring app in the SuperOffice Developer Portal.
author: Bergfrid Dias
so.date: 05.18.2022
keywords: Developer Portal, app, mirroring
so.topic: howto
so.version:
so.envir: cloud
so.client:
---

# Register a mirroring app

## About this template

This template creates a [database mirroring][1] app configuration for one specific customer. It will ask for the public endpoint of your mirroring service URL.

## Required licenses

All custom apps using database mirroring must have a subscription to the **Database Mirroring Service** [Development product][5].

Custom apps may only be used by a customer tenant who have the [Developer Tools license][4].

## Create app

1. In the Developer Portal, go to your partner page.

2. In the **Applications** section, click **Create App**.

3. Choose the **Custom database mirror app** template. Click **Next**.

4. Enter the name of your application. Use **Data mirroring for *Company name*** as the application name. Click **Next**.

    [!include[Requirements for app name](includes/note-app-name.md)]

5. Enter the URL of the integration endpoint.

    Select On/Off to activate the endpoint.

    > [!NOTE]
    > If the endpoint is not yet ready, you may change configuration later.

    ![Mirroring service URL -screenshot][img1]

6. [!include[ALT](includes/set-technical-contact.md)]

    ![Developer Portal set technical contact when creating app -screenshot][img5]

7. Click **Create Application**.

## Update web.config

Required information to put into *web.config* of your mirroring service:

* SoAppId = Client ID
* PrivateKey.txt = Certificate - Paste in the Private key

## What would you like to do next?

* [Check what your client ID is][7]
* [Add a certificate][10]
* [Manage notifications][2]
* [Get error emails][2]
* [Getting started with database mirroring][11]
* [Request to publish the configuration][18]

<!-- Referenced links -->
[1]: ../../mirroring/overview.md
[2]: ../howto/notifications.md
[4]: ../../admin/license/expander-services/tool-box.md
[5]: ../../admin/license/expander-services/index.md#development-products
[7]: ../security/find-clientid.md
[10]: ../security/new-certificate.md
[11]: ../../mirroring/getting-started/create-wfc.md
[18]: ../howto/request-to-publish.md

<!-- Referenced images -->
[img1]: media/mirror-service-url.png
[img5]: media/select-technical-contact.png
