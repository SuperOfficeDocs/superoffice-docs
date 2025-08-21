---
uid: get-category-list-mdoagent
title: Get a CategoryList using the MDO Agent
description: Get a CategoryList through the MDO Agent
keywords: category, MDO agent
author: Tony Yates
date: 10.22.2024
content_type: howto
redirect_from:
  - /en/company/howto/services/get-catlist-mdoagent
  - /en/api/netserver/web-services/howto/company/get-catlist-mdoagent
---

# Get a CategoryList using the MDO Agent

```csharp
using SuperOffice;
using SuperOffice.CRM.Services;

using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //get the MDO agent
  using(MDOAgent mdoAgent = new MDOAgent())
  {
    MDOListItem[] categoryList =
    mdoAgent.GetSimpleList("category");

    //loop through the retrieved list and output them on the console
    foreach (MDOListItem item in categoryList)
    {
      Console.WriteLine(item.Name);
    }
  }
}
```

The example above shows how we can use the `GetSimpleList` method available through the `MDOAgent` to retrieve the category list.
