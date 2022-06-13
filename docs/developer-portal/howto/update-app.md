---
title: Update app
uid: dp-update-app
description: Release a new version of the app
author: Bergfrid Dias
so.date: 04.28.2022
keywords: App Store
so.topic: howto
so.envir: cloud
so.client: online
---

# Release a new version of the app

When you release a new version of your application, your App Store listing can include a **What's new** entry and we can help boost visibility.

**Pre-requisites:**

* You have tested the changes in SOD and Stage
* You the new application code is running in your cloud

**To update the App Store listing:**

1. [Submit a description of your changes][1].
2. Optionally include new images, such as screenshots from your application.

**To publish a new software version:**

1. [Update your App Store listing][1].
2. Ensure provisioning handles any changes.

**To change the technical specification:**

1. Update the app configuration.
2. Request to publish the configuration.

> [!CAUTION]
> If you add database mirroring or webhooks, the tenant administrator must renew the consent to your application. **Users will be locked out from when the change happens until the consent has been given.**

<!-- Referenced links -->
[1]: ../app-store/update-app-page.md
[2]: ../../apps/publish/update-app-form.md
