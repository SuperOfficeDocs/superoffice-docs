---
uid: help-en-user-group-filtering
title: User groups
description: User groups
author: SuperOffice RnD
date: 06.29.2022
keywords: user, group
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: en
---

# User group filtering

SuperOffice CRM users belong to different user groups depending on what type of rights they have. This is defined in the [Users screen][2].

When you specify an item in a list in the Lists screen, you can also specify which user groups the item is visible to, in the **Items** tab. Alternatively, you can go to the **User groups** tab to specify available items for each user group. Both methods are described below.

## Specify user groups for an item

1. [!include[Go to Lists](../includes/goto-lists.md)]

2. [!include[Click arrow and select](../includes/expand-list.md)] the required list.

3. Check **Use grouping and user group filtering for this list** in the upper right corner.

    > [!NOTE]
    > If you do not check **Use grouping and user group filtering for this list**, all items in the list are visible for all user groups.

4. Select the required item in the **Items** list.

5. Select a user group in the **Visible for user groups** list. All the user groups in the organization are displayed here. Click the box next to the required user group to specify that the item should be visible to that group.

    The box will then be marked with a tick (<i class="ph ph-check" aria-hidden="true"></i>).

6. Repeat steps 4 and 5 for each item you want to make visible for particular user groups.

> [!NOTE]
> When you add an item to the **Items** list, it will automatically be visible to all the user groups listed under **Visible for user groups**. You can, if required, remove the checks for the user groups you do not want the items to be visible to.

You can select several user groups for one item. Click **Select all** (<i class="ph ph-check-circle" aria-hidden="true"></i>) to select all the groups, or **Unselect all** (<i class="ph ph-minus-circle" aria-hidden="true"></i>) to remove all selections.

## Specify items for a user group

You can also specify available items for a user group:

1. [!include[Go to Lists](../includes/goto-lists.md)]

2. [!include[Click arrow and select](../includes/expand-list.md)] the required list.

3. Check **Use grouping and user group filtering for this list** in the upper right corner.

    > [!NOTE]
    > If you do not check **Use grouping and user group filtering for this list**, all items in the list will be visible for all user groups.

4. Go to the **User groups** tab.

5. Select a user group in the list.

6. In the **List items available to this user group** list, click the box next to each item that should be visible to that group.

7. Repeat steps 5 and 6 for each user group.

## Related topics

* [Headings][1]

<!-- Referenced links -->
[1]: headings.md
[2]: ../../../user-management/index.md
