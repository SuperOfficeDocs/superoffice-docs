---
uid: help-en-admin-listroles-newrole
title: admin listRoles newRole
description: admin listRoles newRole
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Service
so.topic: help
language: en
---

# Create roles

To create a new role:

1. Select ![icon][img3] **System settings &gt; Roles**.
2. Click the **New role** button. The **Create roles** screen opens.
3. Enter the following information:
    * **Name**: Enter a descriptive name for the role.
    * **Description**: Enter a description for the role.
    * **Copy rights from role**: If you want to copy the rights from an existing role, select a role in this list. Start typing in this field to search for a role.
4. Click **OK**. The role is created. You now need to customize the role.
5. Click on the new role in the list to edit it.
6. The **Role information** tab: You have already filled in the necessary information here.
7. The **Members** tab: This tab is empty, since you have not added any members to the role yet. Members are added from the **Edit users** screen (see [User information](admin.editUser.helpUserInfo.md)).
8. In the **Profiles** tab, you can link element profiles to this new role:
    1. In the **New element profile** list, select the required profile from the list that appears.
    2. Click the **Add** button.
    3. Repeat until you have added all the profiles you want to add. For more details about element profiles, see [Profiles](admin.listProfiles.md).
9. In the **Workflow access** tab, you can specify which stage in the FAQ workflow the members of the role should have access to:
    1. In the **New rights** list, select the required stage from the list that appears.
    2. Check **Can move**, **Can edit** or **Full access** to specify which access level the members of the role should have for the stage in question. (For more information about this, see [Work with workflows](../faq/editKbWorkflow.md).)
    3. Click ![icon][img4].
    4. Repeat until you have added all the stages you want to add.
10. In the **Functional rights** tab, you can specify which rights the members of the role should have:
    * To add a function right: Select an item in the list to the left, and click the right-arrow button ( ![icon][img2] ).
    * To remove a function right: Select an item in the list to the right, and click the left-arrow button ( ![icon][img1]) ).
11. Click **OK** when you are done.

## What would you like to do now?

[Edit roles](admin.listRoles.editRole.md)

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: ../../../../media/icons/arrow-left.png
[img2]: ../../../../media/icons/arrow-right.png
[img3]: ../../../../media/icons/globalmenu-settings-small.png
[img4]: ../../../../media/icons/btn-add.png
