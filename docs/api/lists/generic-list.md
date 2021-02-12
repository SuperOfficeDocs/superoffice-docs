---
title: generic_list_providers      
description: Generic list providers
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords:
so.topic: concept
---

# Generic list providers

When you need to **create lists that have a similar behavior** you can use the generic list provider.

Lists that differ from one another have their own providers. But some lists have the same output and almost the same behavior. That’s where generic `SoList` providers come to play. `SoListProviderFactory` will create an `SoList` provider of the correct type according to the parameters passed.

The following example shows how generic list providers are used to create lists.

```csharp
using SuperOffice;
using SuperOffice.CRM.Lists;
using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  string[] listsToTest = new string[] {
  "Category",
  "Task",
  "Country",
  "Person",
  };
  //Create a provider of Category,Task,Country and Person
  foreach (string list in listsToTest)
  {
    ISoListProvider mdoProvider = SoListProviderFactory.Create(list, "0");
    //Display all the History Items of each list provider in the HistoryListView
    if (mdoProvider.HistoryItems.Count > 0)
    {
      foreach (ISoListItem item in mdoProvider.HistoryItems)
      {
        string historyString;
        historyString = item.Id + " " + item.Name;
        HistoryListView.Items.Add(historyString);
      }
    }
    //Display all the Heading Items of each list provider in the HeadingListView
    if (mdoProvider.HeadingItems.Count > 0)
    {
      foreach (ISoListHeading item in mdoProvider.HeadingItems)
      {
        string headingString;
        headingString = item.Heading.Id + " " + item.Heading.Name;
        HeadingListView.Items.Add(headingString);
      }
    }
    //Display all the Root Items of each list provider in the RootListView
    if (mdoProvider.RootItems.Count > 0)
    {
      foreach (ISoListItem item in mdoProvider.RootItems)
      {
        string rootString;
        rootString = item.Id + " " + item.Name;
        RootListView.Items.Add(rootString);
      }
    }
```

In the `SoListProviderFactory`, there are 8 overloaded `Create` methods providing a typed, customized interface for each list.

In the above example, we are passing the values to the `listname` and `additionalinfo` parameters of the `Create` method. Those 2 parameters determine the type of the provider.

Here we are creating 3 lists, namely Category list, Task list, and Country list.
