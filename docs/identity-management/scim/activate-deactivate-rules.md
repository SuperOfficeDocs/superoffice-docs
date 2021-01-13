---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: activate_deactivate_scim_rules       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Activate and deactivate scim rules # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud               # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Activate and deactivate scim rules

You can turn SCIM rules on and off and also rearrange the order in which they are applied.

## Pre-requisites

* You are [signed in to the SuperOffice Identity Manager][1] and have opened the **Configurations** tab.

## Activate a SCIM rule

* Locate the rule in the **User sync rules** pane and select the checkbox.

## Deactivate a SCIM rule

* Locate the rule in the User sync rules pane and clear the checkbox.

## Change the order of the rules

1. Locate the rule in the **User sync rules** pane.

2. If the rule is expanded, click the arrow to collapse it.

3. Select and hold the rule (anywhere on the shaded area) and then move it up or down the list to its new location.

4. Click **Save**.

    ![user sync rules][img1]

<!-- Referenced links -->
[1]: sign-in-to-scim.md

<!-- Referenced images -->
[img1]: media/image84sls.png
