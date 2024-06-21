---
title: Update app
uid: dp-update-app
description: Update an application
author: Bergfrid Dias
date: 08.26.2022
keywords: App Store
topic: howto
envir: cloud
client: online
---

# Update app

| What to update | How to | Comment |
|---|---|---|
| App Store information only | [Update app page][1] | |
| New software version | Release the new software; [optionally update app page][1]. | The new application code must be running in your cloud.<br />Changes should have been tested in SOD.<br />Ensure provisioning handles any changes. |
| Technical specification | [Update app configuration][2] | Request to publish the configuration. The configuration cannot be used in the requested environment before it is approved. Changes might trigger re-certification and renewal of consent. |

> [!CAUTION]
> If you add database mirroring or webhooks, the tenant administrator must renew the consent to your application. **Users will be locked out from when the change happens until the consent has been given.**

<!-- Referenced links -->
[1]: ../standard-app/app-store/update-app-page.md
[2]: ../create-app/config/update-app-config.md
