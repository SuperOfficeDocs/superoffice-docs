---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: sync_user       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Sync user to SuperOffice now # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud               # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Sync user to SuperOffice now

You can manually synchronize 1 selected user. This is useful when you update SCIM rules affecting a few already synchronized users and you don't want to trigger a full bulk-update.

## Pre-requisites

* You are [signed in to the SuperOffice Identity Manager][1]

## Procedure

1. Open the **Configurations** tab.

2. Select the user you want to sync in the **SCIM users** pane:

      Browse the groups or use the search box.

3. Look at the info displayed in the **Preview** pane:

    * If you are good to go, click **Sync user**. Otherwise, update the SCIM rules, preview again, and sync when OK.

    ![scim preview pane][img1]

<!-- Referenced links -->
[1]: ../sign-in-to-scim.md

<!-- Referenced images -->
[img1]: media/preview-sync-shereen.png
