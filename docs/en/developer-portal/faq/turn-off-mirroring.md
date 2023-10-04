---
uid: mirroring-stop-app
title: How to turn off database mirroring
description: How to turn off database mirroring for a running custom mirror app
author: Margrethe Romnes
so.date: 10.04.2023
keywords: database, mirroring, custom app
so.topic: howto
so.dp-version: 1.14
so.envir: cloud
so.client: online
---

# How to turn off database mirroring

1. Sign in to the Developer Portal and go to your application page.

1. Select **Configuration** from the left menu, [create a new version][2], and publish it to SOD.

1. Open the advanced configuration and select **Mirroring** from the secondary menu.

    ![Database mirroring configuration for application -screenshot][img1]

1. Turn off the toggle below the **Endpoint** field and save the settings.

    ![Database mirroring toggle -screenshot][img2]

1. [Request to publish the configuration][1]

<!-- Referenced links -->
[1]: ../create-app/request-to-publish.md
[2]: ../create-app/versioning.md

<!-- Referenced images -->
[img1]: ../create-app/config/media/mirror-config.png
[img2]: media/endpoint-toggle.png
