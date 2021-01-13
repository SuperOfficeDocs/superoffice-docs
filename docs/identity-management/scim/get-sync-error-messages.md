---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: get_scim_sync_error_messages       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Set up email notifications for SCIM errors # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto                # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud             # cloud or onsite
so.client: online             # online, web, win, pocket, or mobile
---

# Set up email notifications for errors

You can sign up to get email notifications for critical SCIM synchronization errors.

## Pre-requisites

* SuperOffice administrator account with access to user admin.

## Procedure

1. [Sign in to the SuperOffice Identity Manager][1].

2. On the **Configurations** tab, scroll down to the lower-left corner.

3. Enter a valid email address in the **Email notifications** field and click **Save.**

    ![SCIM email notifications][img1]

<!-- Referenced links -->
[1]: sign-in-to-scim.md

<!-- Referenced images -->
[img1]: media/scim-email-notifications.png
