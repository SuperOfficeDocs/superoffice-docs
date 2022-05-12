---
title: Notifications
uid: dp-notifications
description: Manage app notifications in the SuperOffice developer portal.
author: Bergfrid Dias
so.date: 05.12.2022
keywords: devportal, app, notification
so.topic: howto
so.version:
so.envir: cloud
so.client:
---

# Manage app notifications

[!include[Go to the app page](../includes/go-to-app-page.md)]

2. Select **Configuration**.

3. Turn on **Advanced**.

4. Select **Notifications**.

    ![Configure notifications -screenshot][img1]

5. Enter the URL of your endpoint SuperOffice should push notifications to when a tenant change status.

    `https://www.awesomeapp.com/NotifyCustomerStateChange`

    Optionally, turn on **Configure per Environment** to set different URLs for SOD, Stage, and Production.

    ![Configure notifications per environment -screenshot][img2]

6. Click **Save Settings** or **OK**.

7. Request to publish the new configuration.

**Read more:**

* [About tenant status notifications][1]
* [How to parse notifications][2]

<!-- Referenced links -->
[1]: ../../apps/tenant-status/notifications.md
[2]: ../../apps/tenant-status/parse-notifications.md

<!-- Referenced images -->
[img1]: media/notifications.png
[img2]: media/configure-notifications-per-envir.png
