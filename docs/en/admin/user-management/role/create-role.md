---
uid: help-en-role-create
title: Create role
description: Create role
keywords: role, user management
author: digitaldiina
date: 10.24.2025
version: 10.4
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
category: identity management
topic: role
index: true
redirect_from: /en/admin/user-management/learn/role/create-role
language: en
---

# Create a role

[!include[Requirement](../includes/note-anon-req.md)]

1. [!include[Open Roles](../includes/open-roles.md)]

1. Select one of the following tabs:

    * **Associates**: Here you can add roles for employees in your company.
    * **External**:  Here you can add roles for external users (onsite only).

    > [!NOTE]
    > There is only a single role for anonymous users and you cannot create a new one. See [Edit rights for anonymous users][8].

1. Click **Add** under the list.

1. In the **Create New Role** dialog, enter a name for the role in the **Role name** field.

1. Enter a description of the role in the **Description** field.

1. Select one of the following options:

    * Click <i class="ph ph-caret-down" aria-label="Chevron"></i> next to the **Copy rights from** box, and select the role you want to base the new role on.
    * Click <i class="ph ph-caret-down" aria-label="Chevron"></i> and select **Start with blank rights** to create the role from scratch.

1. Click **Save**. The new role is displayed in the **Roles** list.

1. Click the role name in the list to display the rights for the role in the **Data rights** tab.

1. [Enter the data rights in the **Data rights** tab][7].

1. If you are creating roles for associates: Click the **Functional rights** tab.

    In this tab you can determine which functions will be available for the role, for example, mail merge, publishing, exporting selections and administrator access in Settings and maintenance.

    > [!TIP]
    > Hold the mouse pointer over a right to display more information about it.

1. Set the role's [functional rights][6]:

    [!include[How to set functional rights](../includes/add-remove-right.md)]

    The changes are saved automatically.

## Related content

* [Add users][5]
* [Edit roles][4]

<!-- Referenced links -->
[4]: update-role.md
[5]: ../add-associate.md
[6]: functional-rights.md
[7]: set-data-rights-for-role.md
[8]: ../onsite/other-users.md#rights
