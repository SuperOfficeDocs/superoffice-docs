---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: get_scim_config       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Get SCIM config for the AAD enterprise application # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto                # article, howto, reference, concept, guide

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

    ![SCIM sync config][img1]

<!-- Referenced links -->
[1]: ../sign-in-to-scim.md

<!-- Referenced images -->
[img1]: media/scim-sync-config.png
