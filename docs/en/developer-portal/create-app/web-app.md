---
title: Register a web app
uid: dp-register-web-app
description: Describes how to register a new web application in the SuperOffice Developer Portal.
author: Bergfrid Dias
so.date: 06.08.2022
keywords: Developer Portal, app
so.topic: howto
so.version:
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
* [Add a certificate][10]
* [Manage notifications][2]
* [Get error emails][2]
* [Start working on the App Store information][11]
* [Request to publish the configuration][18]

<!-- Referenced links -->
[1]: ../../api/reference/restful/index.md
[2]: ../howto/notifications.md
[4]: ../../api/reference/restful/agent/Webhook_Agent/index.md
[5]: ../../api/authentication/online/index.md#oidc
[7]: ../security/find-clientid.md
[8]: ../security/get-client-secret.md
[9]: ../security/cors-and-redirection-urls.md
[10]: ../security/new-certificate.md
[11]: ../app-store/update-app-page.md
[18]: ../howto/request-to-publish.md

<!-- Referenced images -->
[img4]: media/enter-redirect-urls.png
[img5]: media/select-technical-contact.png
