---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: update_app       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Release a new version of the app # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto           # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Release a new version of the app

When you release a new version of your application, your App Store listing can include a **What's new** entry and we can help boost visibility.

**Pre-requisites:**

* You have tested the changes in SOD and Stage
* You the new application code is running in your cloud

**To update the App Store listing:**

1. [Submit a description of your changes][1] (form).
2. Optionally include new images, such as screenshots from your application.

**To publish a new software version:**

1. [Update your App Store listing][1] (form).
2. Ensure provisioning handles any changes.

**To change the technical specification:**

1. [Submit a change request][2] (form).

> [!CAUTION]
> If you add database mirroring or webhooks, the tenant administrator must renew the consent to your application. **Users will be locked out from when the change happens until the consent has been given.**

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/developer/create-apps/resources/update-app-store-listing/
[2]: https://community.superoffice.com/en/developer/create-apps/resources/change-application/
