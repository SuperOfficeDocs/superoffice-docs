---
title: Notifications
uid: dp-notifications
description: Manage app notifications in the SuperOffice Developer Portal.
author: Bergfrid Dias
so.date: 05.12.2022
keywords: Developer Portal, app, notification
so.topic: howto
so.version:
so.envir: cloud
so.client:
---

# Manage app notifications

[!include[Go to the app page](../includes/go-to-app-page.md)]

1. Select **Configuration**.

1. Turn on **Advanced**.

1. Select **Notifications**.

    ![Configure notifications -screenshot][img1]

1. Enter the URL of your endpoint SuperOffice should push notifications to when a tenant change status.

    `https://www.awesomeapp.com/NotifyCustomerStateChange`

    Optionally, turn on **Configure per Environment** to set different URLs for SOD, Stage, and Production.

    ![Configure notifications per environment -screenshot][img2]

1. Click **Save Settings** or **OK**.

1. Request to publish the new configuration.

## Read more

* [About tenant status notifications][1]
* [How to parse notifications][2]

<!-- Referenced links -->
[1]: ../../apps/tenant-status/notifications.md
[2]: ../../apps/tenant-status/parse-notifications.md

<!-- Referenced images -->
[img1]: media/notifications.png
[img2]: media/configure-notifications-per-envir.png
