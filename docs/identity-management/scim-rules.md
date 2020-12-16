---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: scim_rules       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: SCIM rules                   # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: concepts                      # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---
# SCIM rules

A SCIM rule describes users in their SuperOffice CRM Online tenant.

The [SuperOffice Identity Manager][img1] gives administrators access to a wizard where they can configure rules for how users shall be configured in our system.

* The Azure portal sets the mapping from Azure AD to the SCIM schema.

* The SuperOffice Identity Manager sets the mapping from the SCIM schema to [SuperID user accounts][2]].

![X][img1]

## Tasks

* [Get started with SCIM][3]

* [Add SCIM rules][4]

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/technical/documentation/identity-management/overview/identity-management-gw/
[2]: https://community.superoffice.com/en/technical/documentation/identity-management/concepts/superid/user-accounts-and-passwords/
[3]: https://community.superoffice.com/en/technical/documentation/identity-management/how-to/provision-users-with-scim/
[4]: https://community.superoffice.com/en/technical/documentation/identity-management/concepts/scim-rules/

[img1]: https://community.superoffice.com/contentassets/395a8cc239c745fcb52fff8f3f63fd15/scim-marketing-rule.png
