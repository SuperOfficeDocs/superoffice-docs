---
title: Register a web app
uid: dp-register-web-app
description: Describes how to register a new web application in the SuperOffice Developer Portal.
author: Bergfrid Dias
so.date: 11.15.2023
keywords: Developer Portal, app
so.topic: howto
so.version:
so.dp-version: 1.16
so.envir: cloud
so.client:
---

# Register a web app

## About this template

This template creates a web app configuration that uses [interactive OIDC authentication][5].

* Enables the [WebApi API endpoint][1]
* Enables access to the [Webhook agent][4]

[!include[Required license](includes/cust-app-req-license.md)]

## Create app

1. In the Developer Portal, go to your partner page.

2. In the **Applications** section, click **Create App**.

3. Choose the **Web app** template. Then select whether this is a custom or standard application. Click **Next**.

4. Enter the name of your application. Click **Next**.

    [!include[Requirements for app name](includes/note-app-name.md)]

5. Enter one or more redirect URLs - one per line. Click **Next**.

    ![Enter redirect URL -screenshot][img4]

6. [!include[ALT](includes/set-technical-contact.md)]

    ![Developer Portal set technical contact when creating app -screenshot][img5]

7. Click **Create Application**.

## What would you like to do next?

* [Check what your client ID is][7]
* [Create a new client secret][8]
* [View or change CORS and redirection URLs][9]
* [Add a certificate][6]
* [Manage notifications][18]
* [Get error emails][13]
* [Start working on the App Store information][11]
* [Request to publish the configuration][2]

<!-- Referenced links -->
[1]: ../../api/reference/restful/index.md
[4]: ../../api/reference/restful/agent/Webhook_Agent/index.md
[5]: ../../api/authentication/online/index.md#oidc
[6]: config/new-certificate.md
[7]: config/find-clientid.md
[8]: config/get-client-secret.md
[9]: config/cors-and-redirection-urls.md
[2]: request-to-publish.md
[13]: ../best-practices/error-emails.md
[11]: ../standard-app/app-store/update-app-page.md
[18]: ../best-practices/tenant-status/get-notifications.md

<!-- Referenced images -->
[img4]: media/enter-redirect-urls.png
[img5]: media/select-technical-contact.png
