---
title: How to add a list item
uid: add_list_item
description: How to add a list item
author: {github-id}
so.date: 11.05.2016
keywords: row, list, category, CategoryRow, CategoryGroupLinkRow
so.topic: howto
---

# How to add a list item

There are several lists used in SuperOffice CRM. Most of them are stored in tables in the database.

An explanation of all lists is beyond the scope of this section so we will take the category list as an example. All manipulation of lists can be done the same way, so the knowledge that you gain here can be applied to all lists.

> [!NOTE]
> When using the NetServer Services DLLs, it is not possible to add or remove list items through the web services. Therefore, you will have to create your own code to add items to the list.

## Example 1

[!code-csharp[CS](includes/add-listitem-1.cs)]

In the above example, we have used purely [rows][1] to get the job done.

We have created a `CategoryRow`, filled some basic properties of the row, and saved it. This means that we have a new category and we can now use this category.

We have not stopped at creating a category, but we have created a `CategoryGroupLinkRow` as well. This is necessary to specify that this category belongs to this group. Creating a category group link row makes the category appear for the given group in the GUI.

## Example 2

[!code-csharp[CS](includes/add-listitem-2.cs)]

In the above code, we have created a new category called *Cat-Dush* which is stored in the `Category` table in the database. Then we have created 2 entries into the `CategoryGroupLink` table by creating and saving instances of the `CategoryGroupLinkRow`. This tells us to which user groups the category is visible for.

Next, we have added an entry to the `CategoryHeadingLink` table that determines under which heading the created category should be displayed. The created category can be seen in the SuperOffice CRM Admin as shown below.

![Category page -screenshot][img1]

<!-- Referenced links -->
[1]: ../../rows/index.md

<!-- Referenced images -->
[img1]: media/cat-dush.png
