---
uid: help-en-lists
title: Lists
description: How to edit lists
keywords: list
author: digitaldiina
date: 10.29.2025
version: 10.5
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
redirect_from: 
  - /en/admin/lists/learn/items
  - /en/admin/lists/learn/duplicates
language: en
---

# Lists

SuperOffice CRM contains many default lists, such as customer categories, activity types, sales types, and many more. If you want to change the default lists to fit your company jargon and processes, this how-to guide will show you how to edit lists.

Depending on the type of business your company is in, you can tailor all lists in the system to reflect your business processes and needs. You can create new list items, deactivate unnecessary items, and edit existing ones. Some items, by default, are present in all the lists in SuperOffice CRM.

## Lists screen

The **Lists** screen contains descriptions and definitions of the lists in SuperOffice CRM. Here you can customize the predefined lists supplied with SuperOffice CRM.

[!include[Find specific list](includes/tip-find-list.md)]

You can also add your own user-defined lists which are displayed on the **More** tabs in SuperOffice CRM. You specify what is displayed in the **More** tabs in the [Fields screen][10].

The **Lists** screen is divided into the following parts:

> [!NOTE]
> User groups and headings are not displayed for lists where they are irrelevant.

* At the top of the screen, you can click the list box to choose from among all available lists in SuperOffice, both predefined and [user-defined lists][5].
* The **Items** tab contains the [items](#items) that are available for the selected list.
* The **User groups** tab shows items [filtered by user group][7].
* The **Headings** tab shows [items per heading][1].
* In the **Visible for user groups** list, you can see the group(s) that the item selected in the **Items** list are displayed to. You can for example choose to have different follow-up types available for your Sales, Support and Accounting user groups.
* The **Headings** list shows the [headings][1] under which the individual items are displayed. If a list is very long (contains a large number of items), you can use headings to group the items logically. The items in the **Document - Template** list, for example, are grouped in the **Letter**, **Fax**, **Email** headings and so on.

At the upper right is the **Use grouping and user group filtering for this list** checkbox, where you specify if the list can be grouped and filtered. This option is deactivated for lists where this is irrelevant.

At the bottom of the **Lists** screen is the **Show deleted items and headings** checkbox, which allows you to [undo the deletion][9] of items and headings.

## <a id="items"></a>Items

In contrast to lists themselves, the items contained in both predefined and user-defined lists can be added to, amended or deleted.

### Duplicates

You cannot create two items with the same name in one list. The same applies to headings. If you try to create an element with the same name as an existing item or heading, a message advises you that this is not allowed. This restriction applies irrespective of if the name is in uppercase or lowercase.

> [!NOTE]
> You cannot add a new item or heading that has the same name as a [deleted item or heading][9].

## Related content

* [Organizing lists][3]
* [Specialized lists][4]
* [Add user-defined lists][5]
* [Document templates][6]
* [Add a list item][11]
* [Edit or delete a list item][8]

<!-- Referenced links -->
[1]: organize/headings.md
[3]: organize/index.md
[4]: specialized-lists.md
[5]: ../user-defined-lists.md
[6]: ../../../document/templates/learn/index.md
[7]: organize/user-group-filtering.md
[8]: ../update-items.md
[9]: organize/deleted-items-and-headings.md
[10]: ../../../custom-objects/admin/edit-udef-layout.md
[11]: adding-items.md

<!-- Referenced images -->
