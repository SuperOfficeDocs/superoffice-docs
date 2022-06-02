---
title: Register a web app
uid: dp-register-web-app
description: Registering a new web app in the SuperOffice Developer Portal.
author: Bergfrid Dias
so.date: 05.18.2022
keywords: Developer Portal, app
so.topic: howto
so.version:
so.envir: cloud
so.client:
---

# Register a web app

## About this template

This template creates an standard web app configuration that use user  interactive OIDC authentication.

* enables the *WebApi* API endpoint
* enables access to the *Webhooks* agent.

## Custom app required license

It may only be used by a customer tenant who have the Development tools subscription.

## Create app

1. In the Developer Portal, go to your partner page.

2. In the **Applications** section, click **Create App**.

3. Choose the **Web app** template. Then select whether this is a custom or standard app. Click **Next**.

4. Enter the name of your application. Click **Next**.

    [!include[Requirements for app name](includes/note-app-name.md)]

5. Enter one or more redirect URLs - one per line. Click **Next**.

    ![Enter redirect URL -screenshot][img4]

6. You will be set the technical contact for your app. Click *Clear* to choose another technical contact by email address.

    ![-screenshot][img5]

7. Click **Create Application**.

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
