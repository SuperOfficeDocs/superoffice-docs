---
title: Update endpoints
uid: dp-update-endpoints
description: How to update endpoints (API, ERP, quote, mirroring) in the SuperOffice Developer Portal.
author: Bergfrid Dias
so.date: 11.15.2023
keywords: Developer Portal, endpoint, app
so.topic: howto
so.dp-version: 1.16
so.envir: cloud
so.client: online
---

# Update endpoints

Which SuperOffice endpoints you get access to by default depend on the template you selected when registering the application. [See list of default configuration.][1] We highly recommend that all new apps use our **WebAPI**.

## What can I change?

You can add, remove, and update information about endpoints hosted by you that SuperOffice will send data to:

* ERP sync
* Quote connector
* Database mirror
* Push notifications
* Redirection

These are all part of your **application configuration**.

To get access to additional SuperOffice API endpoints or RESTful agents, you need to contact us.

## How to change configuration

1. In the [Developer Portal][3], go to your application page.
2. Select **Configuration** from the left menu.
3. Turn on **Advanced** (next to the left menu, between the list of versions and the client ID).

    ![Turn on advanced configuration for app -screenshot][img1]

4. Choose from the secondary menu and update values. See details in the following sections.

    ![Advanced app configuration in the Developer Portal -screenshot][img2]

5. Click **Save Settings**.
6. When done, [request to publish the configuration][2].

## ERP sync

1. Open the advanced configuration.
2. Select **ERP** from the secondary menu.

    ![ERP sync configuration for application -screenshot][img3]

3. Update the **Endpoint** field in the **ERP sync** section. Optionally, choose different values per environment.

    ![Configure endpoint per environment -screenshot][img4]

4. [!include[Has integration?](../../includes/has-integration.md)]

5. Save and publish.

## Quote connector

1. Open the advanced configuration.
2. Select **ERP** from the secondary menu.
3. Update the **Endpoint** field in the **Quote connection** section. Optionally, choose different values per environment.
4. [!include[Has integration?](../../includes/has-integration.md)]
5. Save and publish.

## Database mirroring

1. Open the advanced configuration.
2. Select **Mirroring** from the secondary menu.

    ![Database mirroring configuration for application -screenshot][img5]

3. Update the **Endpoint** field. Optionally, choose different values per environment.
4. [!include[Has integration?](../../includes/has-integration.md)]
5. Save and publish.

## Customer state change notifications

This is your public URL where we [push tenant status changes][7] regarding all customers who have approved your application.

## Redirection URLs

For detailed instructions, see [CORS and redirection URLs][6] in the Security section.

<!-- Referenced links -->
[1]: ../index.md#default-config
[2]: ../request-to-publish.md
[3]: https://dev.superoffice.com/
[6]: cors-and-redirection-urls.md
[7]: ../../best-practices/tenant-status/index.md#notify

<!-- Referenced images -->
[img1]: media/toggle-advanced.png
[img3]: media/erp-config.png
[img5]: media/mirror-config.png
[img2]: ../../media/configuration.png
[img4]: ../../best-practices/media/endpoint-per-envir.png
