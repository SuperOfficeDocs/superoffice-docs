---
uid: help-en-deleting-role
title: Deleting a role
description: Deleting a role
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance, role
so.topic: help
language: en
---

# Delete a role

[!include[Requirement](../includes/note-anon-req.md)]

When you delete a role, you must move the users with this role to another role. You should therefore ensure that the users have the correct access in the role you move them to.

**Steps:**

1. [!include[Open Roles](includes/open-roles.md)]

2. Choose the **Associates** or **External** tab.

    > [!NOTE]
    > You cannot delete the role for anonymous users.

3. Select the required role in the **Roles** list.

4. Click **Delete**.

    <details><summary>Is the Delete button disabled (greyed out)?</summary>
    It is not possible to delete the role you yourself belong to or the system user role (**User level 0**). If there is only a single role, you cannot delete it.
    </details>

5. In the **Delete Role** dialog, click the arrow ( ![icon][img3] ) next to the **Assign all users with this role to** field, and select another role for the users of the role you want to delete.

6. Click **Delete**. The role is removed from the list. You cannot undo deletion of a role.

<!-- Referenced links -->

<!-- Referenced images -->
[img3]: ../../../../../media/icons/arrow-down.png
