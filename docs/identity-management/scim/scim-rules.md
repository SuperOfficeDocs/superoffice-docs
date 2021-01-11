---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: scim_rules       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: SCIM rules                   # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: SCIM
so.topic: concepts                      # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud             # cloud or onsite
so.client: online             # online, web, win, pocket, or mobile
---
# SCIM rules

A SCIM rule describes users in their SuperOffice CRM Online tenant.

The [SuperOffice Identity Manager][1] gives administrators access to a wizard where they can configure rules for how users shall be configured in our system.

* The Azure portal sets the mapping from Azure AD to the SCIM schema.

* The SuperOffice Identity Manager sets the mapping from the SCIM schema to [SuperID user accounts][2]].

![SCIM UI rule example][img1]

## Tasks

* [Get started with SCIM][3]

* [Add SCIM rules][4]

<!-- Referenced links -->
[1]: identity-management-gw.md
[2]: ../superid/user-accounts-and-passwords.md
[3]: https://community.superoffice.com/en/technical/documentation/identity-management/how-to/provision-users-with-scim/
[4]: scim-rules.md

<!-- Referenced images -->
[img1]: media/scim-marketing-rule.png
