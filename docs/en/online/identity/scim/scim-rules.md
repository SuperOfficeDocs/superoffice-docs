---
uid: scim-rules
title: SCIM rules
description: SCIM rules for how users shall be configured in SuperOffice CRM.
keywords: SCIM, IdP, Microsoft Entra, ME-ID, AAD, Azure
author: Bergfrid Dias, Oleg Deribas
date: 10.02.2025
version: 10.5.2
content_type: concepts
category: identity management
topic: scim
deployment: online
platform: web
index: true
---

# SCIM rules

A SCIM rule describes users in their SuperOffice CRM Online tenant.

The [SuperOffice Identity Manager][1] gives administrators access to a wizard where they can configure rules for how users shall be configured in our system.

* The Azure portal sets the mapping from Microsoft Entra ID (formerly AAD) to the SCIM schema.

* The SuperOffice Identity Manager sets the mapping from the SCIM schema to [SuperID user accounts][2].

![SCIM UI rule example -screenshot][img1]

## Rule-based user selection

The set of rules in SCIM defines a subset of users that will be synchronized into SuperOffice.

Only users who are affected by at least one rule will be sent to SuperOffice. For example, if an organization has 100 users and 10 groups, and there is only one rule with the condition **In group = Group1**, only users who are members of Group1 will be synchronized. The remaining users will be ignored, even if they are sent to SCIM from Entra ID.

User selection happens in two steps:

1. In Microsoft Entra ID, by selecting which users or groups to provision to SCIM.
2. In SCIM, by applying one or more rules that determine if a user is included.

If there is at least one active rule with **NotInGroup** scope, all users in the tenant will be synchronized.

## Property updates

As of version 10.5.2, SCIM will not change a property unless there is a rule that explicitly sets a value. This applies only to properties that are controlled by SCIM rules.

Some rule elements allow you to select a scope for how the property should be applied. There are two possible scopes:

* **Always:** The value is updated even if it was already set by a previous rule.
* **If not set:** The value is only set if it has not already been set by a previous rule.

Use scopes to control how multiple rules interact when setting the same property.

## Related content

* [Get started with SCIM][3]
* [Add SCIM rules][4]

<!-- Referenced links -->
[1]: identity-management-gw.md
[2]: ../superid/user-accounts-and-passwords.md
[3]: overview.md
[4]: provisioning/add-scim-rule.md

<!-- Referenced images -->
[img1]: media/scim-marketing-rule.png
