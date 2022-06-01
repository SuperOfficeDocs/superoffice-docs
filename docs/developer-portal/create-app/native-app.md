---
title: Register a native app
uid: dp-register-native-app
description: Registering a new native app in the SuperOffice Developer Portal.
author: Bergfrid Dias
so.date: 05.18.2022
keywords: Developer Portal, app
so.topic: howto
so.version:
so.envir: cloud
so.client:
---

# Register a native app
This template creates an app configuration that use OAuth2 Native app flow which depends on Proof Key for Code Exchange (PKCE). 
 
* default adds in **^http://127.0.0.1\:\d{4,10}$** as allowed redirect URL. You may add more.
* enables the **WebApi** API endpoint and add access to the Webhooks agent.
* checks **Is native or mobile** application on the authentication pane.



1. In the Developer Portal, go to your partner page.

2. In the **Applications** section, click **Create App**.

3. Choose the **Native app** template. Then select whether this is a custom or standard app. Click **Next**.

4. Enter the name of your application. Click **Next**.

    [!include[Requirements for app name](includes/note-app-name.md)]

5. Optionally enter more redirect URLs - one per line. Click **Next**.

    ![Enter redirect URL -screenshot][img4]

6. Set the technical contact for your app.

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
[3]: ../howto/get-error-emails.md
[7]: ../security/find-clientid.md
[8]: ../security/get-client-secret.md
[9]: ../security/cors-and-redirection-urls.md
[10]: ../security/new-certificate.md
[11]: ../app-store/update-app-page.md

<!-- Referenced images -->
[img4]: media/enter-redirect-urls.png
[img5]: media/select-technical-contact.png
