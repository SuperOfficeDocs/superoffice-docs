---
title: user_defined_list_providers
description: User-defined list providers
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords:
so.topic: concept
---

# User-defined list providers

Users can define their own fields and tables. If you need to create a list for a user-defined field or table, it is done via a user-defined list provider.

The following example demonstrates how this is done.

```csharp
using SuperOffice;
using SuperOffice.CRM.Lists;
using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //Retrieve a userDifined list provider
  ISoListProvider mdoProvider = SoLists.GetUserDefinedList(4);
  //Check whether it contains any history items
  if (mdoProvider.HistoryItems.Count > 0)
  {
    //Display the History Items
    foreach (ISoListItem item in mdoProvider.HistoryItems)
    {
      string historyString;
      historyString = item.Id + " " + item.Name;
      HistoryListView.Items.Add(historyString);
    }
  }
  //Check whether it contains any Heading items
  if (mdoProvider.HeadingItems.Count > 0)
  {
    //Display the Heading Items
    foreach (ISoListHeading item in mdoProvider.HeadingItems)
    {
      string headingString;
      headingString = item.Heading.Id + " " + item.Heading.Name;
      HeadingListView.Items.Add(headingString);
    }
  }
  //Check whether it contains any Root items
  if (mdoProvider.RootItems.Count > 0)
  {
    //Display the Root Items
    foreach (ISoListItem item in mdoProvider.RootItems)
    {
      string rootString;
      rootString = item.Id + " " + item.Name;
      RootListView.Items.Add(rootString);
    }
  }
}
```

When creating a list for a user-defined table or field, we have to give the ID of the list we need.

Thus `udlist` requires an integer ID to identify which of the multiple lists in that table should be created. The behavior of this list provider differs from the rest only by the fact that it searches the `udlist` instead of the `conceptualtable` to retrieve lists.

In the above example, we have created a user-defined list for the user-defined List with ID 4. Using the provider, we can retrieving the `Historyitems`, `Headingitems`, and `Rootitems` if that list has any.
