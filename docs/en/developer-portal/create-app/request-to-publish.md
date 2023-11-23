---
title: Request to publish
uid: dp-request-publish
description: How to request to publish App Store Information and application configuration the SuperOffice Developer Portal.
author: Bergfrid Dias
so.date: 11.15.2023
keywords: Developer Portal, publish
so.topic: howto
so.dp-version: 1.16
so.envir: cloud
so.client: online
---

# Request to publish

[!include[When to publish](includes/ready-to-publish.md)]

![Request to publish in the Development Portal -screenshot][img1]

[!include[What needs approval for Stage and Production?](includes/what-to-publish.md)]

In all three cases, after you click the **Request to Publish** button we create a support ticket and follow up with you via email. The workflow is different for standard and custom applications.

> [!TIP]
> If you don't see the version you want to publish, click **More versions**.
>
> Confused about versions? [Check out our in-depth guide.][1]

Watch the walk-through on YouTube:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube-nocookie.com/embed/kqEpAw7qQEY?start=1918]

## Application - Configuration

1. In the [Developer Portal][9], go to your application page.
2. Select **Configuration** from the left menu.
3. Click the **Request to Publish** button.
4. The version is now listed as pending. Look for the support email from us. The configuration cannot be used in the requested environment before it is approved.

Need to update something?

* [Client secret][4]
* [Certificate (RSA private key)][5]
* [CORS and redirection URLs][6]
* [Notifications][7]
* [Mirroring, ERP sync, or quote endpoints][8]
* For any other values, contact the App Manager via our chat.

## Application - App Store information

1. In the Developer Portal, go to your application page.
2. Select **App Store information** from the left menu.
3. Click the **Request to Publish** button.
4. The version is now listed as pending. Look for the support email from us.

Need to update something? [Follow these steps][3].

## Partner - App Store information

1. In the Developer Portal, go to your partner page.
2. Select **App Store information** from the left menu.
3. Click the **Request to Publish** button.
4. The version is now listed as pending. Look for the support email from us.

Need to update something? [Follow these steps][2].

<!-- Referenced links -->
[1]: versioning.md
[2]: ../standard-app/app-store/update-partner-profile.md
[3]: ../standard-app/app-store/update-app-page.md
[4]: config/get-client-secret.md
[5]: config/new-certificate.md
[6]: config/cors-and-redirection-urls.md
[8]: config/update-endpoints.md
[9]: https://dev.superoffice.com/
[7]: ../best-practices/tenant-status/get-notifications.md

<!-- Referenced images -->
[img1]: ../media/request-to-publish.png
