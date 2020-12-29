---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: superid_terms_and_conditions       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description:                    # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {frodeb@superoffice.com}             # Your GitHub alias.
keywords: SuperID
so.topic:    reference                   # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir:      cloud               # cloud or onsite
so.client:      online              # online, web, win, pocket, or mobile
---

# SuperID terms and conditions

## Passwords and authentication when migrate from Onsite to CRM Online

Users' passwords of this tenant will be moved to [SuperID.][1]

**SuperID will handle authentication**, including managing passwords (set/reset) for non-federated users.

All authentication features are moved from the local onsite tenant to SuperID.

[Password administration][2] will be self-service.

**SuperOffice administrators will lose their ability to set and reset a user's password from the SuperOffice Admin client.**

> [!NOTE] The **set new password** feature of SuperID requires users to validate their authentication through 2-step email verification.

All tenants in CRM Online is **not eligible to use** the [**password policy** preferences][3] in SuperOffice Admin, as this is not used when using either SuperID or your IdP service for authentication.

## User creation

> [!NOTE] The **create a new user** feature from Admin requires users to validate their authentication through 2-step email verification.

You must, therefore, have access to this new user's email to verify the user before you are able to use it and sign in.

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/technical/documentation/identity-management/concepts/superid/
[2]: https://community.superoffice.com/en/technical/documentation/identity-management/how-to/reset-password/
[3]: https://community.superoffice.com/en/technical/documentation/identity-management/how-to/enforce-password-policy/