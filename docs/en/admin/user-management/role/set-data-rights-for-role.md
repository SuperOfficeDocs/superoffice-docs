---
uid: help-en-role-set-data-rights
title: Set data rights for role
description: Set data rights for role
keywords: user management, role, access, rights
author: digitaldiina
date: 03.27.2025
version: 10.4
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
category: identity management
topic: role
index: true
redirect_from: /en/admin/user-management/learn/role/set-data-rights-for-role
language: en
---

# Set data rights for a role

[!include[Requirement](../includes/note-anon-req.md)]

You can set rights for data objects based on who owns the object. All users who belong to this [role][2] will be assigned rights based on the settings you make here.

## Steps

1. [!include[Open Roles](../includes/open-roles.md)]

1. Choose the **Associates** tab or the **External** tab (onsite).

    [How to edit the role for anonymous users.][1]

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
| My Company (E)<br />ONSITE only | Created by an external user's company | Owner field applies | Responsible field applies | "Our contact" applies |
| Other groups (A) | Created by a user group you belong to | Owner field applies | Responsible field applies | "Our contact" is an associate from a user group you belong to |
| Same project (E)<br />ONSITE only | Created in a project an external user belongs to | Owner field applies | Responsible field applies | "Our contact" applies |
| Other associates | Created by other associates in the company | Owner field applies | Responsible field applies | "Our contact" is an associate that you do not share a user group with |
| External user | Created by external users (Audience users) | Owner field applies | Responsible field applies | "Our contact" applies |
| Anonymous | Created by anonymous users | Not applicable | Not applicable | Not applicable |

**A** = Associates, **E** = External

On the Contact card, the **Our contact** field always pulls the associate from the Company card that the contact belongs to.

## How do I display data objects for external users?

If the data objects (companies, projects, documents and so on) to make accessible to external users (Audience users), it is not enough just to assign the external users read (or higher) access. The data objects must also be published in SuperOffice.

## Related content

* [Functional rights][3]

<!-- Referenced links -->
[1]: ../onsite/other-users.md#rights
[2]: index.md
[3]: functional-rights.md
