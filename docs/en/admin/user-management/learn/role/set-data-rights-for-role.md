---
uid: help-en-role-set-data-rights
title: Set data rights for role
description: Set data rights for role
keywords: user management, role, access, rights
author: Bergfrid Dias
date: 12.10.2024
version: 10
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: en
---

# Set data rights for a role

[!include[Requirement](../includes/note-anon-req.md)]

You can set rights for [data objects][2] based on who owns the object. All users who belong to this [role][2] will be assigned rights based on the settings you make here.

## Steps

1. [!include[Open Roles](includes/open-roles.md)]

2. Choose the **Associates** tab or the **External** tab (onsite).

    [How to edit the role for anonymous users.][1]

3. Select the required role in the **Roles** list. The rights for the selected role are displayed in the **Data rights** tab.

4. Click the ![icon][img3] arrow next to the right you want to change, and select the required right.

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

| Data owned by | Explanation|
|---|---|
| My own | Created by you |
| Primary group (A) | Created by your primary group (department) |
| My Company (E) | Created by an external user's company |
| Other groups (A) | Created by a user group you belong to |
| Same project (E) | Created in a project an external user belongs to |
| Other associates | Created by other associates in the company |
| External user | Created by external users (Audience users) |
| Anonymous | Created by anonymous users |

* A = Associates
* E = External

## How do I display data objects for external users?

If the data objects (companies, projects, documents and so on) to make accessible to external users (Audience users), it is not enough just to assign the external users read (or higher) access. The data objects must also be published in SuperOffice.

## Related

* [Functional rights][3]

<!-- Referenced links -->
[1]: edit-rights-for-anonymous-users.md
[2]: index.md
[3]: functional-rights.md

<!-- Referenced images -->
[img3]: ../../../../../media/icons/arrow-down.png
