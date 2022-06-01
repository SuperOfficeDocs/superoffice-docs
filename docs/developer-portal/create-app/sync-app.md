---
title: Register an ERP and quote sync app
uid: dp-register-sync-app
description: Registering a new ERP and quote sync app in the SuperOffice Developer Portal.
author: Bergfrid Dias
so.date: 05.18.2022
keywords: Developer Portal, app, ERP
so.topic: howto
so.version:
so.envir: cloud
so.client:
---

# Register an ERP and quote sync app
This template creates an standard app configuration that ask for the Erp and Quote endpoint.

* enables the WebApi and Services88 API endpoint.
* enable access to the SystemToken claim and add access to the Webhooks agent.
* ask for the ERP Sync and Quote URL in the wizard.
* grant Integration server under licenses so the Sync / Quote panel is active in customers admin client.

1. In the Developer Portal, go to your partner page.

2. In the **Applications** section, click **Create App**.

3. Choose the **Standard ERP sync and quote app** template. Click **Next**.

4. Enter the name of your application. Click **Next**.

    [!include[Requirements for app name](includes/note-app-name.md)]

5. Enter the URL of the integration endpoints.

    ![Mirroring service URL -screenshot][img1]

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
[img1]: media/erp-integration-points.png
[img5]: media/select-technical-contact.png
