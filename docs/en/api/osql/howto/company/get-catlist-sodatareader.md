---
uid: get-category-list-sodatareader
title: Get the CategoryList through SODataReader
description: Get the CategoryList through SODataReader
keywords: category, CategoryHeadingLinkTableInfo, CategoryList
author: Bergfrid Dias
date: 02.22.2022
content_type: howto
redirect_from:
  - /en/company/howto/osql/get-catlist-sodatareader
  - /en/api/netserver/osql/howto/company/get-catlist-sodatareader
---

# Get the CategoryList through SODataReader

[SODataReader][1] also facilitates us in obtaining category lists. Here you have to query the database to retrieve the `CategoryList`.

[!include[ALT](../../../includes/note-using-sodatareader.md)]

## Code

The following example demonstrates how it is done.

```csharp
using SuperOffice.Data;
using SuperOffice.CRM.Data;
using SuperOffice.Data.SQL;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //Create a category table and a categoryheading table
  CategoryTableInfo categoryTable = TablesInfo.GetCategoryTableInfo();
  CategoryHeadingLinkTableInfo categoryHeading = TablesInfo.GetCategoryHeadingLinkTableInfo();

  //Writing the Query to retrieve the Items coming under each heading in the categoryheadinglink table
  Select selectCategory = S.NewSelect();
  selectCategory.ReturnFields.Add(categoryTable.CategoryId, categoryTable.Name, categoryHeading.HeadingId);
  selectCategory.JoinRestriction.LeftOuterJoin(categoryTable.CategoryId.Equal(categoryHeading.CategoryId));
  selectCategory.GroupBy.Grouping.Add(categoryHeading.HeadingId, categoryTable.CategoryId, categoryTable.Name);
  SoConnection con = ConnectionFactory.GetConnection();
  SoCommand cmd = con.CreateCommand();
  cmd.SqlCommand = selectCategory;
  con.Open();

  //Execute the Query
  SoDataReader reader = cmd.ExecuteReader();

  //Write the category ID, category name, and heading ID on the list view
  while (reader.Read())
  {
    ListView.Items.Add(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());
  }
}
```

## Walk-through

Here we make a query to retrieve the `CategoryList` from the [category database table][2]. If any category has a heading then there will be a link provided in the [categoryheadinglink table][3].

We have grouped items in the category list according to their headings. If any record in the `category` table doesn’t have a heading then "0" will be returned as the `HeadingId`. Similarly, you can obtain the history items by querying the [history table][4].

<!-- Referenced links -->
[1]: ../../so-data-reader.md
[2]: ../../../../database/tables/category.md
[3]: ../../../../database/tables/categoryheadinglink.md
[4]: ../../../../database/tables/history.md
