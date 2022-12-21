---
title: Typed list providers
uid: typed_list_providers
description: Typed list providers
author: {github-id}
so.date: 05.11.2016
keywords:
so.topic: concept
---

# Typed list providers

Typed list providers are the specific list providers that can be directly created using the `SoLists` class. You can create various types of list providers using this class.

The behavior of `TypedListProviders` varies. Each provider has 3 different types of items:

* HeadingItems
* HistoryItems
* RootItems

For typed list providers, the way each item is defined can differ, and therefore they are specialized for their functionality.

## Create a typed list provider

The following example shows how to create a typed list provider.

```csharp
using SuperOffice;
using SuperOffice.CRM.Lists;
using(SoSession newSession = SoSession.Authenticate("SAL0", ""))
{
  //Retrieve a typed list provider of type Associate
  ISoListProvider mdoProvider = SoLists.GetAssociateList();
  //Check whether it contains any history items
  if (mdoProvider.HistoryItems.Count > 0)
  {
    //if it contains any display them in the HistoryListView
    foreach (ISoListItem item in mdoProvider.HistoryItems)
    {
      string historyString;
      historyString = item.Id + " " + item.Name;
      HistoryListView.Items.Add(historyString);
    }
  }
  //Check whether it contains any heading items
  if (mdoProvider.HeadingItems.Count > 0)
  {
    //Display the heading items in the HeadingListView
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
    //Display root items in the RootListView
    foreach (ISoListItem item in mdoProvider.RootItems)
    {
      string rootString;
      rootString = item.Id + " " + item.Name;
      RootListView.Items.Add(rootString);
    }
  }
}
```

Here we create an associate list provider by using the `GetAssociateList` method of the `SoList` class. Each item in a list has a set of properties, and we have retrieved only 2 of these properties - `Name` and `Id`.

The history items are defined in the `History` table with the table ID field referring to the table ID of the `Associate` table. Not all lists have history items:

* When MDO mode is turned on for a list, a record will be added to the `History` table for each item selected from that list,
* If its MDO mode is turned off, the history items of that list will be empty.

The `RootItems` are defined by the records in the corresponding table only if the MDO mode is set to false. If the MDO mode is set to true, root items contain just items that have not been assigned to a heading. This is why the root items may be empty.

Generally, all the `HeadingItems` are taken directly from the `heading` table. If a particular list doesn't have a record in that table, it will not have any heading item. A heading with no items in it will be hidden. A heading must have items to be included. But the behavior of the TypeList Providers does differ from one another, and therefore the history, heading, and root items may be different. For example, heading items of the associates are defined in the `UserGroup` table. Hence in the above example, the heading items are taken from that table.

> [!NOTE]
> The `ListName` generally corresponds to a conceptual table in the database. However, some tables have multiple lists associated with them. For example, an associate can be viewed as an associate list, a resource list, or both. And also, some lists do not correspond to tables at all or hybrids of tables and hard-coded values.
