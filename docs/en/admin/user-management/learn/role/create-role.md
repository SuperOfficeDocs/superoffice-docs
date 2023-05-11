---
uid: help-en-role-create
title: Create role
description: Create role
author: Bergfrid Dias
so.date: 03.15.2023
keywords: role, user management
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: en
---

# Create a role

[!include[Requirement](../includes/note-anon-req.md)]

1. [!include[Open Roles](includes/open-roles.md)]

2. Select one of the following tabs:

    * **Associates**: Here you can add roles for employees in your company.
    * **External**:  Here you can add roles for external users (onsite only).

    > [!NOTE]
    > There is only a single role for anonymous users and you cannot create a new one. See [Edit rights for anonymous users][5].

3. Click **Add** under the list.

4. In the **Create New Role** dialog, enter a name for the role in the **Role name** field.

5. Enter a description of the role in the **Description** field.

6. Select one of the following options:

    * Click the ![icon][img5] arrow next to the **Copy rights from** box, and select the role you want to base the new role on.
    * Click the ![icon][img5] arrow and select **Start with blank rights** to create the role from scratch.

7. Click **Save**. The new role is displayed in the **Roles** list.

8. Click the role name in the list to display the rights for the role in the **Data rights** tab.

9. [Enter the data rights in the **Data rights** tab][7].

10. If you are creating roles for associates: Click the **Functional rights** tab.

    In this tab you can determine which functions will be available for the role, for example, mail merge, publishing, exporting selections and administrator access in Settings and maintenance.

    > [!TIP]
    > Hold the mouse pointer over a right to display more information about it. Read more about [Functional rights][6] in our FAQ.

11. Set the role's functional rights:

    [!include[How to set functional rights](includes/add-remove-right.md)]

    The changes are saved automatically.

## What would you like to do now?

* [Add users][5]
* [Edit roles][4]

<!-- Referenced links -->
[4]: editing-role.md
[5]: ../add-associate.md
[6]: https://community.superoffice.com/en/support-faqs/faq/whichare-all-availablefunctional-rights-in-superoffice-and-what-each-of-them-mean/
[7]: set-data-rights-for-role.md

<!-- Referenced images -->
[img5]: ../../../../../media/icons/arrow-down.png
