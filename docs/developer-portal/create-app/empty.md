---
title: Register a empty app config
uid: dp-register-empty-app-config
description: Registering a new web app in the SuperOffice Developer Portal.
author: Margrethe Romnes
so.date: 06.02.2022
keywords: Developer Portal, app
so.topic: howto
so.version:
so.envir: cloud
so.client:
---

# Register a empty app config

## About this template

This template creates an app configuration without asking for .

* enables the *WebApi* and *Services88 API endpoint*
* enables access to the *Webhooks* agent.

## Custom app required license

It may only be used by a customer tenant who have the Development tools subscription.

## Create app

1. In the Developer Portal, go to your partner page.

2. In the **Applications** section, click **Create App**.

3. Choose the **Empty** template. Then select whether this is a custom or standard app. Click **Next**.

4. Enter the name of your application. Click **Next**.

    [!include[Requirements for app name](includes/note-app-name.md)]

5. You will be set the technical contact for your app. Click *Clear* to choose another technical contact.

    ![-screenshot][img5]

6. Click **Create Application**.

7. Change to **Advanced** (we will make this the default mode for this template type in next release)

    * Versioning: Overview of version name and history of when this config version was saved.
    * Authentication: This is where you may enable OpenID Connect native, find Client ID and set redirect URLs
    * Secrets & Certificates: Add or create new secret and certificate (used by system user flow and ErpSync/Mirroring)
    * API endpoints: read-only for partners
    * Notifications: Enable and change your customer state notification URL
    * ERP: Enable and change your Quote and ERP Sync endpoints
    * Mirroring: Enable and change your database mirroring endpoint
    * License: read-only for partners
    * Advanced: read-only for partners
    * Verification: read-only for partners

## What would you like to do next?

* [Check what your client ID is][7]
* [Create a new client secret][8]
* [View or change CORS and redirection URLs][9]
* [Add a certificate][10]
* [Manage notifications][2]
* [Get error emails][3]
* [Start working on the App Store information][11]
* Request to publish the configuration

<!-- Referenced links -->
[2]: ../howto/notifications.md
[3]: ../manage-app/get-error-emails.md
[7]: ../security/find-clientid.md
[8]: ../security/get-client-secret.md
[9]: ../security/cors-and-redirection-urls.md
[10]: ../security/new-certificate.md
[11]: ../app-store/update-app-page.md

<!-- Referenced images -->
[img4]: media/enter-redirect-urls.png
[img5]: media/select-technical-contact.png
