---
# Mandatory fields.
title: get_category_list_sodatareader       # (Required) Very important for SEO.
description: Get the CategoryList through SODataReader  # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords: category, rows
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Get the CategoryList through SODataReader

[SODataReader][1] also facilitates us in obtaining category lists. Here you have to query the database to retrieve the `CategoryList`. The following example demonstrates how it is done.

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

  //Write the category ID , category name and heading ID on the list view
  while (reader.Read())
  {
    ListView.Items.Add(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());
  }
}
```

Here we make a query to retrieve the `CategoryList` from the `category` table in the database. If any category has a heading then there will be a link provided in the `categoryheadinglink` table.

We have grouped items in the category list according to their headings. If any record in the `category` table doesn’t have a heading then "0" will be returned as the `HeadingId`. Similarly, you can obtain the history items by querying the `history` table.

<!-- Referenced links -->
[1]: ../../osql/so-data-reader.md
