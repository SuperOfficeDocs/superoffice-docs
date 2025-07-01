---
title: Add new scim rule
uid: add_scim_rule
description:
author: SuperOffice Product and Engineering
date: 01.15.2024
keywords: SCIM, Microsoft Entra, ME-ID, AAD
content_type: howto
deployment: online
platform: web
index: true
---

# Add new scim rule

Let's look at how you can add a [SCIM rule][1] to map Microsoft Entra users to SuperOffice account settings.

## Pre-requisites

* You are [signed in to the SuperOffice Identity Manager][2].

## Procedure

1. Open the **Configurations** tab.

2. Click the plus sign (+) in the upper-right corner of the **User sync rules** pane.

    ![add new SCIM rule -screenshot][img1]

3. Set which users the rule applies to:

    * all
    * only users in 1 specific group
    * all users except those in a specific group

4. Select the settings these users should be mapped to in SuperOffice.

    ![SCIM fallback rule -screenshot][img2]

5. Click **Save**.

> [!TIP]
> You can choose if the selected mapping shall be applied only if the value is empty **(Is not set)** or applied as an override to all matched users **(Always).**

<!-- Referenced links -->
[1]: ../scim-rules.md
[2]: ../sign-in-to-scim.md

<!-- Referenced images -->
[img1]: media/add-scim-rule.png
[img2]: media/scim-fallback-rule.png
