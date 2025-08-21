---
uid: get-category-list-listagent
title: Get a CategoryList using the ListAgent
description: Get a CategoryList through ListAgent
keywords: category, list agent
author: Tony Yates
date: 02.21.2022
content_type: howto
redirect_from:
  - /en/company/howto/services/get-catlist-listagent
  - /en/api/netserver/web-services/howto/company/get-catlist-listagent
---

# Get a CategoryList using the ListAgent

```csharp
using SuperOffice;
using SuperOffice.CRM.Services;

using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //get the list agent
  using(ListAgent listAgent = new ListAgent())
  {
    //retrieve the category list using the methods of the agent
    Category[] catList =  listAgent.GetCategories();

    //loop through the list and output the value to the console
    foreach (Category item in catList)
    {
      if (item != null)
      {
        Console.WriteLine(item.Value);
      }
    }
  }
}
```

Here we have used the ListAgent to retrieve the category list. `ListAgent` offers specific methods to retrieve the lists that have been exposed by the NetServer. It returns an array of Category objects rather than general MDOListItems. However, the Category objects have no means of grouping the items into headings. It is always just a simple list of items.
