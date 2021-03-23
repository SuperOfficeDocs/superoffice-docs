---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: add_scim_rule       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description:                    # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud               # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Add new scim rule

Let's look at how you can add a [SCIM rule][1] to map Azure AD users to SuperOffice account settings.

## Pre-requisites

* You are [signed in to the SuperOffice Identity Manager][2].

## Procedure

1. Open the **Configurations** tab.

2. Click the plus sign (+) in the upper-right corner of the **User sync rules** pane.

    ![add new SCIM rule][img1]

3. Set which users the rule applies to:

    * all
    * only users in 1 specific group
    * all users except those in a specific group
4. Select the settings these users should be mapped to in SuperOffice.

    ![SCIM fallback rule][img2]

5. Click **Save**.

> [!TIP]
> You can choose if the selected mapping shall be applied only if the value is empty **(Is not set)** or applied as an override to all matched users **(Always).**

<!-- Referenced links -->
[1]: ../scim-rules.md
[2]: ../sign-in-to-scim.md

<!-- Referenced images -->
[img1]: media/add-scim-rule.png
[img2 ]: media/scim-fallback-rule.png
