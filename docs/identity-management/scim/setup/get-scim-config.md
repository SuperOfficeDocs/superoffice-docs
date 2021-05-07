---
title: get_scim_config
description: Get SCIM config for the AAD enterprise application
author: {github-id}
keywords:
so.topic: howto
# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud             # cloud or onsite
so.client: online             # online, web, win, pocket, or mobile
---

# Get SCIM config for the AAD enterprise application

When setting up an Azure enterprise application for SCIM, you need to fetch the admin credentials from the SuperOffice Identity Manager.

## Pre-requisites

* SuperOffice administrator account with access to user admin.

## Procedure

1. [Sign in to the SuperOffice Identity Manager][1].

2. Click **SCIM Sync Config** in the upper right corner.

3. Copy the tenant URL and token from the dialog box.

    ![SCIM sync config -screenshot][img1]

<!-- Referenced links -->
[1]: ../sign-in-to-scim.md

<!-- Referenced images -->
[img1]: media/scim-sync-config.png
