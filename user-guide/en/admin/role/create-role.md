---
uid: help-en-create-role
title: Create role
description: Create role
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Create a role

[!include[Requirement](../includes/note-anon-req.md)]

To create a role for associates in the company or for external users:

1. Click the **Roles** button in the Navigator (![icon][img3]).

2. Select one of the following tabs:
    * **Associates**: Here you can add roles for employees in your company.
    * <!-- onsite-->**External**: Here you can add roles for external users.
    * ![icon][img5] <!-- Fix reuse ID=a3 -->
        <!-- onsite--> There is only a single role for anonymous users and you cannot create a new one. See [Edit rights for anonymous users](Edit-rights-for-anonymous-users.md).

3. Click **Add** under the list. The **Create New Role** dialog opens.

4. Enter a name for the role in the **Role name** field.

5. Enter a description of the role in the **Description** field.

6. Select one of the following options:
    * Click the arrow (![icon][img4] ) next to the **Copy rights from**, and select the role you want to base the new role on.
    * Or
    * Click the arrow (![icon][img4] ) and select **Start with blank rights** to create the role from scratch.

7. Click **Save**. The new role is displayed in the **Roles** list.

8. Click the role name in the list to display the rights for the role in the **Data rights** tab.

9. Enter the data rights in the **Data rights** tab as described under [Set data rights for a role][1].
    <!-- Fix reuse ID=a2 -->
    [!include[Table showing rights per role](../includes/table-role-rights.md)]

10. If you are creating roles for associates: Click the **Functional rights** tab. In this tab you can determine which functions will be available for the role, e.g. mail merge, publishing, exporting selections and administrator access in Settings and maintenance.

    > [!TIP]
    > Hold the mouse pointer over a right to display more information about it.

11. To add a right: Select one or more rights in the **This role CANNOT** field, and click the right arrow ( ![icon][img1] ).

12. To remove a right: Select one or more rights in the **This role can** field, and click the left arrow ( ![icon][img2] ).

The changes are saved automatically.

## What would you like to do now?

* [Add users][2]

<!-- Referenced links -->
[1]: set-data-rights-for-role.md
[2]: ../users/adding-users-web.md

<!-- Referenced images -->
[img1]: ../../../media/icons/pil-hoeyre.bmp
[img2]: ../../../media/icons/pil-venstre.bmp
[img3]: ../../../media/icons/admin/knapp-rolle-liten.bmp
[img4]: ../../../media/icons/admin/pil-ned.bmp
[img5]: ../../../media/icons/admin/question.bmp
