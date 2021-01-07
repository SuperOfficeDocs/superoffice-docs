---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: tenant_approval_sequence       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Tenant approval sequence # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: reference             # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Tenant approval sequence

No one **may** ask for a customer's username and password to gain access to the tenant's resources. Everyone must adhere to the following authorization sequence.

![Authorization sequence][img1]

## Post-approval

The user who approved the application appears in the App Store with the date the application was added.

![image5n4c.png][img2]

> [!NOTE]
> A customer's administrator may authorize the application by clicking a link that includes your client ID. This will show the [consent dialog][1] for the application and as an administrator, they may click **I approve**.

<!-- Referenced links -->
[1]: get-consent.md

<!-- Referenced images -->
[img1]: media/appvendorconsultants.png
[img2]: media/image5n4c.png
