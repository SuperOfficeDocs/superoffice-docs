---
uid: dp-update-endpoints
title: Update endpoints
description: How to update endpoints (API, ERP, quote, mirroring) in the SuperOffice Developer Portal.
keywords: Developer Portal, endpoint, app
author: Bergfrid Dias
date: 02.26.2025
version: 2.0
version_devportal: 2.0
topic: howto
envir: cloud
client: online
---

# Update endpoints

Which SuperOffice endpoints you get access to by default depend on the template you selected when registering the application. [See list of default configuration.][1] We highly recommend that all new apps use our **WebAPI**.

## What can I change?

You can add, remove, and update information about endpoints hosted by you that SuperOffice will send data to:

* ERP sync
* Quote connector
* Database mirror
* [Push notifications][7]
* [CORS and redirection URLs][6]

These are all part of your **application configuration**.

To get access to additional SuperOffice API endpoints or HTTP RPC Agents, you need to contact us.

## Steps

1. In the [Developer Portal][3], go to your application page.

1. Select **Configuration** from the left menu.

1. Select the **Integration settings** tab.

    ![App configuration in the Developer Portal -screenshot][img2]

1. Update values in the appropriate **Endpoint** field. Optionally, choose different values per environment.

    ![Configure endpoint per environment -screenshot][img4]

    [!include[Has integration?](../../includes/has-integration.md)]

1. Click **Save Settings**.

1. When done, [request to publish the configuration][2].

<!-- Referenced links -->
[1]: ../index.md#default-config
[2]: ../request-to-publish.md
[3]: https://dev.superoffice.com/
[6]: cors-and-redirection-urls.md
[7]: ../../best-practices/tenant-status/index.md#notify

<!-- Referenced images -->
[img2]: ../../media/integration-settings.png
[img4]: ../../best-practices/media/endpoint-per-envir.png
