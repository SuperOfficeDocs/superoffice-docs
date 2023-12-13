---
title: SCIM rules
uid: scim_rules
description: SCIM rules
author: {github-id}
so.date:
keywords: SCIM
so.topic: concepts
so.envir: cloud
so.client: online
---
# SCIM rules

A SCIM rule describes users in their SuperOffice CRM Online tenant.

The [SuperOffice Identity Manager][1] gives administrators access to a wizard where they can configure rules for how users shall be configured in our system.

* The Azure portal sets the mapping from Azure AD to the SCIM schema.

* The SuperOffice Identity Manager sets the mapping from the SCIM schema to [SuperID user accounts][2].

![SCIM UI rule example -screenshot][img1]

## Related content

* [Get started with SCIM][3]
* [Add SCIM rules][4]

<!-- Referenced links -->
[1]: identity-management-gw.md
[2]: ../superid/user-accounts-and-passwords.md
[3]: overview.md
[4]: scim-rules.md

<!-- Referenced images -->
[img1]: media/scim-marketing-rule.png
