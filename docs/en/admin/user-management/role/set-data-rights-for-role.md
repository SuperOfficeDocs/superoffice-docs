---
uid: help-en-role-set-data-rights
title: Set data rights for role
description: Set data rights for role
keywords: user management, role, access, rights
author: digitaldiina
date: 06.10.2026
version: 12.0
content_type: howto
tier: starter
audience: settings
audience_tooltip: Settings and maintenance
category: identity management
topic: role
index: true
redirect_from: /en/admin/user-management/learn/role/set-data-rights-for-role
language: en
---

# Set data rights for a role

[!include[Requirement](../../../includes/lim-starter.md)]

You can set rights for data objects based on who owns the object. All users who belong to this [role][2] will be assigned rights based on the settings you make here.

## Steps

1. [!include[Open Roles](../includes/open-roles.md)]

1. Choose the **Associates** tab.

1. Select the required role in the **Roles** list. The rights for the selected role are displayed in the **Data rights** tab.

1. Click <i class="ph ph-caret-down" aria-label="Chevron"></i> next to the right you want to change, and select the required right.

    | Name | Rights | Tooltips |
    |---|---|---|
    | None | No rights | |
    | Read | Read rights | R |
    | Create | Read and create rights | CR |
    | Update | Read, create and update rights | CRU |
    | Delete | Read, create, update and delete rights | CRUD |

    **C** = Create, **R** = Read, **U** = Update, **D** = Delete

    The changes are saved automatically.

## What do the different columns under Data owned by mean?

| **Data owned by** | **Dashboards and Documents** | **Sales and Activities** | **Projects** | **Company and Contact** |
|---|---|---|---|---|
| My own | Created by you | Owner field applies | Responsible field applies | You are "Our contact" |
| Primary group (A) | Created by your primary group (department) | Owner field applies | Responsible field applies | "Our contact" is an associate in your primary group |
| Other groups (A) | Created by a user group you belong to | Owner field applies | Responsible field applies | "Our contact" is an associate from a user group you belong to |
| Other associates | Created by other associates in the company | Owner field applies | Responsible field applies | "Our contact" is an associate that you do not share a user group with |
| Anonymous | Created by anonymous users | Not applicable | Not applicable | Not applicable |

**A** = Associates

On the Contact card, the **Our contact** field always pulls the associate from the Company card that the contact belongs to.

## Related content

* [Functional rights][3]
* [Onsite data rights][4]

<!-- Referenced links -->
[2]: index.md
[3]: functional-rights.md
[4]: https://help.superoffice.com/docs/11/en/admin/user-management/role/set-data-rights-for-role.html
