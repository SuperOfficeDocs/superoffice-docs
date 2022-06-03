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

This template creates a database mirroring app configuration for one specific customer, it will ask for the public endpoint of your mirroring service URL.

Required information to put into web.config of your mirroring service:

* SoAppId = Client ID
* PrivateKey.txt = Certificate - Paste in the Private key

## Custom app required license

It may only be used by a customer tenant who have the Database mirroring subscription.

## Create app

1. In the Developer Portal, go to your partner page.

2. In the **Applications** section, click **Create App**.

3. Choose the **Custom database mirror app** template. Click **Next**.

4. Enter the name of your application. Click **Next**.

    [!include[Requirements for app name](includes/note-app-name.md)]

5. Enter the URL of the integration endpoint.

    ![Mirroring service URL -screenshot][img1]

6. You will be set the technical contact for your app. Click *Clear* to choose another technical contact by email address.

    ![-screenshot][img5]

7. Click **Create Application**.

## What would you like to do next?

* [Check what your client ID is][7]
* [Add a certificate][10]
* [Manage notifications][2]
* [Get error emails][3]
* [Getting started with database mirroring][11]
* Request to publish the configuration

<!-- Referenced links -->
[2]: ../howto/notifications.md
[3]: ../howto/get-error-emails.md
[7]: ../security/find-clientid.md
[10]: ../security/new-certificate.md
[11]: ../../mirroring/getting-started/create-wfc.md


<!-- Referenced images -->
[img1]: media/mirror-service-url.png
[img5]: media/select-technical-contact.png
