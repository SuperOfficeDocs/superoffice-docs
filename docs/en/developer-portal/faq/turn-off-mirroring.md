---
uid: mirroring-stop-app
title: How to turn off database mirroring
description: How to turn off database mirroring for a running custom mirror app
keywords: database, mirroring, custom app
author: Margrethe Romnes
date: 08.21.2024
version_devportal: 1.25
topic: howto
envir: cloud
client: online
---

# How to turn off database mirroring

1. Sign in to the Developer Portal and go to your application page.

1. Select **Configuration** from the left menu, [create a new version][2], and publish it to SOD.

1. Select the **Integration settings** tab.

    ![Database mirroring configuration for application -screenshot][img1]

1. In the **Data mirroring** section, turn off the toggle below the **Endpoint** field and save the settings.

    ![Database mirroring toggle -screenshot][img2]

1. [Request to publish the configuration][1]

<!-- Referenced links -->
[1]: ../create-app/request-to-publish.md
[2]: ../create-app/versioning.md

<!-- Referenced images -->
[img1]: ../media/integration-settings.png
[img2]: media/endpoint-toggle.png
