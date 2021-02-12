---
title: add_list_item
description: How to add a list item
author: {github-id}
so.date: 11.05.2016
keywords: row
so.topic: howto
---

# How to add a list item

There are several lists used in SuperOffice CRM. Most of them are stored in tables in the database.

An explanation of all lists is beyond the scope of this section so we will take the category list as an example. All manipulation of lists can be done the same way, so the knowledge that you gain here can be applied to all lists.

```csharp
using SuperOffice;
using SuperOffice.CRM.Rows;
using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //create a category row
  CategoryRow myCategory = CategoryRow.CreateNew();
  myCategory.SetDefaults();

  //give it a name
  myCategory.Name = "This is a category test";

  //set the rank
  myCategory.Rank = 5;

  //give a tool tip
  myCategory.Tooltip = "This is test tooltip";

  //save the row
  myCategory.Save();

  //create a category group link row
  CategoryGroupLinkRow myGroupLinkRow = CategoryGroupLinkRow.CreateNew();

  //set the group ID that you want
  myGroupLinkRow.GroupId = 2;

  //set the category ID
  myGroupLinkRow.CategoryId = myCategory.CategoryId;

  //save the category row
  myGroupLinkRow.Save();
}
```

In the above example, we have used purely [rows][1] to get the job done.

We have created a `CategoryRow`, filled some basic properties of the row, and saved it. This means that we have a new category and we can now use this category.

We have not stopped at creating a category, but we have a created a `CategoryGroupLinkRow` as well. This is necessary to specify that this category belongs to this group. Creating a category group link row makes the category appear for the given group in the GUI.

<!-- Referenced links -->
[1]: ../rows/index.md
