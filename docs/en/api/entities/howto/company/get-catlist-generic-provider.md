---
uid: get-category-list-generic-provider
title: Get a CategoryList through generic list providers
description: Get a CategoryList through generic list providers
keywords: category, list provider, CategoryList
author: Tony Yates
date: 05.11.2016
content_type: howto
redirect_from:
  - /en/company/howto/entity/get-catlist-generic-provider
  - /en/api/netserver/entities/howto/company/get-catlist-generic-provider
---

# Get a CategoryList through generic list providers

```csharp
using SuperOffice;
using SuperOffice.CRM.Lists;
using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
    ISoListProvider categoryList = SoListProviderFactory.Create("category");
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

By passing the correct parameters to the `Create` method of the `SoListProviderFactory`, you can create a `CategoryList`. `Create()` has 7 overloads providing a typed, customized interface for each list.

In the example above, we have passed the name of the list needed (category). The way how `RootItems`, `HeadingItems`, and `HistoryItems` are defined is consistent for all the [generic lists][1].

All `RootItems` are taken for the corresponding table, in this case, the  [category table][3]. If the MDO mode of the [CategoryList][2] is turned on, then some records may be present in the [history table][4] corresponding to the category list so that the history list may be nonempty. Similarly, if the [heading table][5] contains records corresponding to the category list, then the `HeadingItems` of the category list will also be nonempty.

<!-- Referenced links -->
[1]: ../../../lists/entity/generic-list.md
[2]: ../../../../company/dev/index.md#categorylist
[3]: ../../../../database/tables/category.md
[4]: ../../../../database/tables/history.md
[5]: ../../../../database/tables/heading.md
