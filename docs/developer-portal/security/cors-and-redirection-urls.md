---
title: CORS and redirection URLs
uid: dp-add-update-redirect
description: CORS and redirection URLs in the SuperOffice Developer Portal.
author: Bergfrid Dias
so.date: 05.13.2022
keywords: Developer Portal, app, client ID
so.topic: howto
so.version:
so.envir: cloud
so.client:
---

# CORS and redirection URLs

The redirection endpoints are specified and whitelisted when you register the application idea. All changes to whitelisted URLs have be approved SuperOffice.

Types of URLs:

* Default redirect URL
* Allowed redirect URLs
* Allowed postLogout redirect URLs
* CORS URLs

> [!NOTE]
> All can optionally be configured per environment.
>
> You can list multiple of each type (except default) if you put one per line.
>
> Consider if whitelisting is sufficient or do you need a CORS redirect?

## Pre-requisites

* You have registered your application idea
* You are (or will be) handling web service requests at the new endpoints

## To view redirection endpoints

[!include[Go to the app page](../includes/go-to-app-page.md)]

1. Select **Configuration**.

    ![Allowed redirects -screenshot][img1]

1. If not shown on the **Configuration** start page, toggle **Advanced** and select **Authentication**.

    ![Application configuration: authentication URLs -screenshot][img2]

## To add or update redirection endpoints

1. Open the **Authentication** page as described above.
2. Enter new values, optionally per environment.
3. Click **Save Settings**.
4. Request to publish the new configuration.

> [!CAUTION]
> If you add database mirroring or webhooks, the tenant administrator must [renew the consent][4] to your application. **Users will be locked out from when the change happens until the consent has been given.**

## Read more

* [About redirects][1]
* [Endpoint types][2]

<!-- Referenced links -->
[1]: ../../apps/redirects/index.md
[2]: ../../apps/redirects/endpoint-types.md
[4]: ../../apps/provisioning/get-consent.md

<!-- Referenced images -->
[img1]: media/allowed-redirects.png
[img2]: media/app-authentication.png