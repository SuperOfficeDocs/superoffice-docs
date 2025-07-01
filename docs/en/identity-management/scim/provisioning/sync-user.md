---
title: Sync user to SuperOffice now
uid: sync_user
description: Sync user to SuperOffice now
author: SuperOffice Product and Engineering
keywords:
content_type: howto
deployment: online
platform: web
index: true
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

    ![scim preview pane -screenshot][img1]

<!-- Referenced links -->
[1]: ../sign-in-to-scim.md

<!-- Referenced images -->
[img1]: media/preview-sync-shereen.png
