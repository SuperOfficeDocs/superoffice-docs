---
uid: get-category-list-typed-provider
title: Get a CategoryList through typed list providers
description: Get a CategoryList through typed list providers
keywords: category, list provider, CategoryList
author: Tony Yates
date: 05.11.2016
content_type: howto
redirect_from:
  - /en/company/howto/entity/get-catlist-typed-provider
  - /en/api/netserver/entities/howto/company/get-catlist-typed-provider
---

# Get a CategoryList through typed list providers

In the `SoList` class, there are specific methods to create different types of list providers. Hence there is a method specialized in creating `CategoryList` providers too.

The following example shows how to get a [category list][2] using [typed list providers][1].

```csharp
using SuperOffice;
using SuperOffice.CRM.Lists;
using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  ISoListProvider categoryList = SoLists.GetCategoryList();
  //Retrieving the History items of the AssociateList
  if (categoryList.HistoryItems.Count > 0)
  {
    foreach (ISoListItem item in categoryList.HistoryItems)
    {
      string historyString;
      historyString = item.Id + " " + item.Name;
      HistoryListView.Items.Add(historyString);
    }
  }
  //Retrieving the HeadingItems of the AssociateList
  if (categoryList.HeadingItems.Count > 0)
  {
    foreach (ISoListHeading item in categoryList.HeadingItems)
    {
      string headingString;
      headingString = item.Heading.Id + " " + item.Heading.Name;
      HeadingListView.Items.Add(headingString);
    }
  }
  //Retrieving the RootItm
  if (categoryList.RootItems.Count > 0)
  {
    foreach (ISoListItem item in categoryList.RootItems)
    {
      string rootString;
      rootString = item.Id + " " + item.Name;
      RootListView.Items.Add(rootString);
    }
  }
}
```

By using the `CategoryList` method defined in the `SoList` class you can obtain a `CategoryList` provider.

There are 3 different items present in the `CategoryList` provider: HeadingItems, HistoryItems, and RootItems. Each of these items contains its own properties and in this example, we have used only the `Id` and the `Name` properties.

The `HistoryItems` are defined in the [history table][1] with its `table_Id` field referring to the conceptual table ID of the [category table][4]. Unless the MDO mode of the `Contact` list is turned on, no record will be added to the `history` table.

The `RootItems` are defined by the records in the `category` table only if the MDO mode is set to false. If the MDO mode is set to true then the `RootItems` contain only the items that have not been assigned to any Heading. Normally all the HeadingItems are taken directly from the [heading table][5].

**Output of the example:**

![Get a CategoryList through typed list providers -screenshot][img1]

<!-- Referenced links -->
[1]: ../../../lists/entity/typed-list.md
[2]: ../../../../company/dev/index.md#categorylist
[4]: ../../../../database/tables/category.md
[5]: ../../../../database/tables/heading.md

<!-- Referenced images -->
[img1]: media/image002.jpg
