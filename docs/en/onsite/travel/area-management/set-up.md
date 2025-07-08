---
title: Set up Area Management
uid: set_up_area_management
description: How to set up Area Management
author: SuperOffice Product and Engineering
keywords:
content_type: howto
deployment: onsite
platform: win
---

# Set up Area Management

The best way to visualize how to define areas within your company is to "define the users from the bottom up", starting by defining areas that contain only one user's data and then defining the areas that contain more than one user's data.

**Available associates** are all users that have been defined as employees in the **Users** panel in the Admin client. They are listed in the **Area Definition** dialog and can be assigned log-in access rights.

![Area definition dialog -screenshot][img1]

> [!NOTE]
> There are 2 lists called **Available associates**. The top one is used when assigning users to an area. The bottom one is used when setting access rights.

A user can only be assigned to one area at a time, but more than one user could have log-in rights to an area. You can actually have log-in rights to an area where your own data is not included, but this is not recommended.

* When you assign a user to an area, they are moved from the top **Available associates** list to the **Included associates** list.
* When you assign access rights to that user, they move from the bottom **Available associates** list to the **Assigned associates** list.

In the scenarios below, the areas of user A and user B contain only their data respectively, while user C's area contains not only the data of user C but also the data of user A and user B.

## Pre-requisites

Before you begin the area definition, you should:

* Decide which areas you want to divide the database into
* Decide which employees’ data should be included in each area
* Decide which user or users have sign-on access rights to an area

> [!NOTE]
> Area Management is accessible from the **Replication** panel in SOAdmin. You need the **General administrator** functional right to access the **Area Management** menu.

## Steps

1. Select **Define Areas** on the **Replication** panel in SOAdmin.

2. In the **Area Management** dialog, click **New**.

3. In the **Area Definition** dialog, enter a descriptive name for the area into the **Area Name** field.

4. Highlight the user and click the right arrows to move them to the desired list.

    Use the top lists to assign users to an area. Use the bottom lists to set access rights.

5. Click **OK** to save. You return to the **Area Management** dialog where the new area now is listed in **Defined Areas**.

> [!NOTE]
> You must generate an [Update Prototype][1] for each area defined before a user can perform the Local Update.

## Scenarios

### Area A with only user A's data

1. In the **Area Definition** dialog, enter *area A* into the **Area Name** field.

2. Highlight *User A* in the top **Available associates** list and click the *right* arrow next to the list.

    User A is now listed as an included associate.

3. Highlight *User A* in the bottom **Available associates** list and click the *right* arrow next to the list.

    User A is now listed as an assigned associate.

4. Click **OK** to save.

    Area A is now listed in the **Area Management** dialog under **Defined Areas**.

Repeat steps 1-4 to define the area for user B / area B.

### Area C with records of users A and B also included

1. In the **Area Definition** dialog, enter *area C* into the **Area Name** field.

2. Highlight User A, User B, and User C and move them to the **Included associates** list.

3. Highlight User C and move them to the **Assigned associates** list.

4. Click **OK** to save.

    Areas A, B, and C are now listed in the **Area Management** dialog under **Defined Areas**.

### 2 users including the data belonging to 2 other users

If we use the example with the sales-persons Peter, Paul, Marie, and Lynne as a starting point, we will now define an area for Peter and Paul including Peter’s, Paul’s, Marie’s, and Lynne’s data.

1. In the **Area Definition** dialog, enter *Customer Group California* into the **Area Name** field.

2. Highlight Peter, Paul, Marie, and Lynne, and move them to the **Included associates** list.

3. Highlight Peter and Paul and move them to the **Assigned associates** list.

4. Click **OK** to save.

    Area *Customer Group California* is now listed in the **Area Management** dialog under **Defined Areas**.

## Edit an Area

Sometimes it may be necessary to edit an area, for example, if a new employee should be added to an area.

1. From the **File** menu, select **Travel** and then select **Area Management**.
2. In the **Area Management** dialog, highlight the area to edit and click **Edit**.
3. Make the desired changes to the area. Click **OK** when done.

## Delete an Area

An area can be deleted if no longer needed.

> [!NOTE]
> Make sure that the area is not in use by any users before deleting.

1. From the **File** menu, select **Travel** and then select **Area Management**.
2. In the **Area Management** dialog, highlight the area to delete and click **Delete**.
3. In the **Delete Area** dialog, click **OK**.

## View Assignments

To view which users are assigned sign-on rights to which areas, click the **View Assign** button.

<!-- Referenced links -->
[1]: ../update-prototype.md

<!-- Referenced images -->
[img1]: media/area-definition-dialog.png
