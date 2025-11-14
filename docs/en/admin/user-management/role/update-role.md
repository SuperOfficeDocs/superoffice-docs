---
uid: help-en-role-edit
title: Update role
description: How to edit a role.
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
redirect_from: 
  - /en/admin/user-management/learn/role/editing-role
  - /en/admin/user-management/learn/role/deleting-role
language: en
---

# Update role

[!include[Requirement](../includes/note-anon-req.md)]

To update or delete a [role][3], start by selecting the role from the **Associates** or **External** tab.

1. [!include[Open Roles](../includes/open-roles.md)]

1. Choose the **Associates** or **External** tab.

    [How to edit the role for anonymous users.][1]

1. In the list, double-click the role you want to edit.

## Edit a role

1. In the **Create New Role** dialog, change the name and description of the role as required and then click **Save**.

1. [Edit the role's rights.][4]

1. If you are editing roles for associates: Go to the **Functional rights** tab and edit the role's functional rights.

    [!include[How to set functional rights](../includes/add-remove-right.md)]

    The changes are saved automatically.

## Delete a role

When you delete a role, you must move the users with this role to another role. You should therefore ensure that the users have the correct access in the role you move them to.

> [!NOTE]
> You cannot delete the role for anonymous users or the system user role (**User level 0**).
>
> **You cannot undo deletion of a role.**

1. With the role selected, click **Delete**.

    * Is the Delete button disabled (greyed out)? It is not possible to delete the role you yourself belong to. If there is only a single role, you cannot delete it.

1. In the **Delete Role** dialog, click <i class="ph ph-caret-down" aria-label="Chevron"></i> to the **Assign all users with this role to** field, and select another role for the users of the role you want to delete.

1. Click **Delete**.

    * The role is removed from the list.

<!-- Referenced links -->
[1]: ../onsite/other-users.md#rights
[3]: index.md
[4]: set-data-rights-for-role.md
