---
uid: help-en-user-group-filtering
title: User groups
description: User groups
keywords: user group
author: digitaldiina
date: 10.29.2025
version: 10.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: /en/admin/lists/learn/organize/user-group-filtering
language: en
---

# User group filtering

SuperOffice CRM users belong to different user groups depending on what type of rights they have. This is defined in the [Users screen][2].

When you specify an item in a list in the Lists screen, you can also specify which user groups the item is visible to, in the **Items** tab. Alternatively, you can go to the **User groups** tab to specify available items for each user group. Both methods are described below.

> [!NOTE]
> If you do not check **Use grouping and user group filtering for this list**, all items in the list are visible for all user groups.

## Enable grouping

1. [!include[Go to Lists](includes/goto-lists.md)]

1. Select the desired list from the dropdown menu in the upper-left corner of the Lists screen.

1. Check **Use grouping and user group filtering for this list** in the upper right corner.

## Specify user groups for an item

1. Select the required item in the **Items** list.

1. Select a user group in the **Visible for user groups** list. All the user groups in the organization are displayed here. Click the box next to the required user group to specify that the item should be visible to that group.

    The box will then be marked with a tick (<i class="ph ph-check" aria-hidden="true"></i>).

1. Repeat steps for each item you want to make visible for particular user groups.

> [!NOTE]
> When you add an item to the **Items** list, it will automatically be visible to all the user groups listed under **Visible for user groups**. You can, if required, remove the checks for the user groups you do not want the items to be visible to.

You can select several user groups for one item. Click **Select all** (<i class="ph ph-check-circle" aria-hidden="true"></i>) to select all the groups, or **Unselect all** (<i class="ph ph-minus-circle" aria-hidden="true"></i>) to remove all selections.

## Specify items for a user group

You can also specify available items for a user group:

1. Go to the **User groups** tab.

1. Select a user group in the list.

1. In the **List items available to this user group** list, click the box next to each item that should be visible to that group.

1. Repeat steps for each user group.

## Related content

* [Headings][1]

<!-- Referenced links -->
[1]: headings.md
[2]: ../user-management/index.md
