---
# Mandatory fields.
title: get_category_list_categoryrows       # (Required) Very important for SEO.
description: Get the CategoryList via CategoryRows object  # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords: category, rows
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Get the CategoryList via CategoryRows object

`CategoryRows` are defined under `SuperOffice.CRM.Rows` namespace. You can even get a category list via the `CategoryRows` object.

```csharp
using SuperOffice.CRM.Rows;
using SuperOffice.Data;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
CategoryRows.CustomSearch mySearch = newCategoryRows.CustomSearch();
  //Add a Search Restriction to make sure that only the rows with the Field Deleted = 0 will be returned
  mySearch.Restriction = mySearch.TableInfo.Deleted.Equal ( S.Parameter( 0 ) );

  //Retrieve CategoryRows through CustomSearch
  CategoryRows myResult = CategoryRows.GetFromCustomSearch( mySearch );

  //Display the CategoryID and the Name on the ListView
  foreach (CategoryRow row in myResult)
  {
    ListView.Items.Add(row.CategoryId + " " + row.Name);
  }
}
```

We have first created an instance of the `CustomSearch` class. Through this, we are trying to retrieve all the category rows which are not deleted. In this example, we are simply retrieving a list of categories. You can even group those categories according to their headings by adding more restrictions to the `CustomSearch` instance.

The above example is a very simple demonstration of how a category list is obtained via `CategoryRows` object. You can even enhance it according to your requirement.
