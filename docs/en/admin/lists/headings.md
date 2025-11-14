---
uid: help-en-list-headings
title: List headings
description: Use headings to group items in long lists in Settings and maintenance.
keywords: heading, organize list
author: digitaldiina
date: 10.29.2025
version: 10.5
content_type: reference
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from:
  - /en/admin/lists/learn/organize/index
  - /en/admin/lists/learn/organize/headings
  - /en/admin/lists/learn/organize/adding-headings
  - /en/admin/lists/learn/organize/headings-editing-and-deleting
  - /en/admin/lists/learn/organize/grouping-items-under-headings
language: en
---

# List headings

List items can be displayed at two levels. The higher level is called the item's **heading**. A heading contains item groups that can be displayed under the selected item in SuperOffice CRM. The same items can appear under several headings.

The **Headings** list (in the lower right of the **Lists** screen) shows which headings the individual items are displayed under. You can also go to the **Headings** tab to see which items appear under a specific heading.

## When is it a good idea to use headings in lists?

If a list is very long (it contains a large number of items), you can use headings to group the items logically. The items in the **Document templates** list, for example, are grouped in the **Letter**, **Fax**, **Email** headings and so on.

## Working with headings in lists

To manage headings, open the **Lists** screen and select the desired list from the dropdown menu in the upper-left corner of the Lists screen.

> [!NOTE]
> Headings are only available for lists where **Use grouping and user group filtering for this list** is enabled (checkbox in upper-right).
>
> The checkbox is disabled for some predefined lists (such as **General - User group**) that cannot be grouped.

There are two ways to assign headings:

* **From the Items tab**: Select a list item and assign it one or more headings from the **Headings** panel.
* **From the Headings tab**: Select a heading and assign it one or more items to display beneath it.

You can also add, edit, or delete headings as needed.

## <a id="add"></a>Add heading

Before linking a heading to an item, you must add the headings you require.

1. Go to the **Headings** tab.

1. Click the **Add** button below the **Headings** list to add a new heading.

1. In the dialog, enter the required name for the heading *(Mandatory)* and a description (*Optional*).

    * The **Description** field can be used to clarify the purpose of the heading and may appear as tooltip text in the interface.

1. [!include[Save or cancel](includes/save-or-cancel.md)]

The item is added to the **Headings** list. Repeat this procedure to add more headings.

After adding the required headings, [choose which headings each item will be displayed under](#group).

## <a id="group"></a>Group items under headings

If you want a list with two levels, you must select headings for each individual item in the **Items** list in the **Lists** screen. Alternatively, you can go to the **Headings** tab to specify available items for specific headings. Both methods are described below.

> [!NOTE]
> The list must consist of a certain minimum number of items to be displayed in this way. This number is defined in the [Preferences screen][3].

### Choose headings for a list item

Any headings already specified for the selected list are displayed in the **Headings** list at the lower right. If this field is empty, [add headings first](#add).

1. Select the required item in the **Items** list.

1. Check the box next to the required heading name in the **Headings** list to specify that the selected list item will be displayed under it. The box will then be marked with a tick (<i class="ph ph-check" aria-hidden="true"></i>).

    The changes are saved automatically.

> [!TIP]
> You can select several headings for one item.

### Choose list items for a heading

1. Go to the **Headings** tab.

1. Select a heading in the list.

1. In the **List items under this heading** list, click the box next to each item that should be visible under the selected heading.

1. Repeat steps 2 and 3 for each heading.

    The changes are saved automatically.

## <a id="update"></a>Edit headings

You edit headings by double-clicking the relevant heading in the **Headings** list and changing the information.

## Delete headings

You delete headings by checking the relevant heading in the **Headings** list and clicking **Delete**.

> [!NOTE]
> Deleting a heading does **not** remove the associated list items. You can [restore deleted headings][2].

<!-- Referenced links -->
[2]: restore.md
[3]: ../preferences/index.md

<!-- Referenced images -->
