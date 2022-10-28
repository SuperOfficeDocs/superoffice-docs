---
uid: help-en-create-role
title: Create role
description: Create role
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance, role
so.topic: help
language: en
---

# Create a role

[!include[Requirement](../includes/note-anon-req.md)]

## In Settings and maintenance

To create a role for associates in the company or for external users:

1. [!include[Open Roles](includes/open-roles.md)]

2. Select one of the following tabs:

    * **Associates**: Here you can add roles for employees in your company.
    * **External**:  <!-- onsite-->Here you can add roles for external users.

    > [!NOTE]
    > There is only a single role for anonymous users and you cannot create a new one. See [Edit rights for anonymous users][5].

3. Click **Add** under the list. The **Create New Role** dialog opens.

4. Enter a name for the role in the **Role name** field.

5. Enter a description of the role in the **Description** field.

6. Select one of the following options:

    * Click the arrow (![icon][img5] ) next to the **Copy rights from**, and select the role you want to base the new role on.
    * Click the arrow (![icon][img5] ) and select **Start with blank rights** to create the role from scratch.

7. Click **Save**. The new role is displayed in the **Roles** list.

8. Click the role name in the list to display the rights for the role in the **Data rights** tab.

9. [!include[How to set data rights](includes/enter-data-rights.md)]

    <details><summary>What do the different rights mean?</summary>
    [!include[Table showing rights per role](includes/table-role-rights.md)]
    </details>

10. If you are creating roles for associates: Click the **Functional rights** tab.

    In this tab you can determine which functions will be available for the role, e.g. mail merge, publishing, exporting selections and administrator access in Settings and maintenance.

    > [!TIP]
    > Hold the mouse pointer over a right to display more information about it. Read more about [Functional rights][6] in our FAQ.

11. Set the role's functional rights:

    [!include[How to set functional rights](includes/add-remove-right.md)]

    The changes are saved automatically.

## In Service

To create a new role:

1. Select ![icon][img3] **System settings** > **Roles**.

2. Click the **New role** button. The **Create roles** screen opens.
3. Enter the following information:
    * **Name**: Enter a descriptive name for the role.
    * **Description**: Enter a description for the role.
    * **Copy rights from role**: If you want to copy the rights from an existing role, select a role in this list. Start typing in this field to search for a role.
4. Click **OK**. The role is created. You now need to customize the role.
5. Click on the new role in the list to edit it.
6. The **Role information** tab: You have already filled in the necessary information here.
7. The **Members** tab: This tab is empty, since you have not added any members to the role yet. Members are added from the **Edit users** screen (see [User information][1]).
8. In the **Profiles** tab, you can link [element profiles][2] to this new role:
    1. In the **New element profile** list, select the required profile from the list that appears.
    2. Click the **Add** button.
    3. Repeat until you have added all the profiles you want to add.
9. In the **Workflow access** tab, you can specify which [stage in the FAQ workflow][3] the members of the role should have access to:
    1. In the **New rights** list, select the required stage from the list that appears.
    2. Check **Can move**, **Can edit** or **Full access** to specify which access level the members of the role should have for the stage in question.
    3. Click ![icon][img4].
    4. Repeat until you have added all the stages you want to add.
10. In the **Functional rights** tab, you can specify which rights the members of the role should have:
    * To add a function right: Select an item in the list to the left, and click the right-arrow button ( ![icon][img2] ).
    * To remove a function right: Select an item in the list to the right, and click the left-arrow button ( ![icon][img1]) ).
11. Click **OK** when you are done.

## What would you like to do now?

* [Add users][5]
* [Edit roles][4]

<!-- Referenced links -->
[1]: ../../settings/personal-settings/user-info.md
[2]: ../../ui/service-screens/listProfiles.md
[3]: ../../faq/workflow.md
[4]: editing-role.md
[5]: ../add-associate.md
[6]: https://community.superoffice.com/en/support-faqs/faq/whichare-all-availablefunctional-rights-in-superoffice-and-what-each-of-them-mean/

<!-- Referenced images -->
[img5]: ../../../media/icons/arrow-down.png
[img1]: ../../../media/icons/arrow-left.png
[img2]: ../../../media/icons/arrow-right.png
[img3]: ../../../media/icons/globalmenu-settings-small.png
[img4]: ../../../media/icons/btn-add.png
