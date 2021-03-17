---
title: group_view_providers   
description: Group view providers
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords:
so.topic: concept
---

# Group view providers

GroupView Providers are another type of list providers. In the diary of SuperOffice, we have 4 tabs which are Day, Week, Month, and View. The Group View list defines the user groups and the user's own custom definitions of users as a list so that we can display it as a dropdown.

The following example demonstrates how a group view list provider is created.

```csharp
using SuperOffice;
using SuperOffice.CRM.Lists;
using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //Retrieve a Group View Provider
  ISoListProvider mdoProvider = SoLists.GetGroupViewList();
  //If it contains any HistoryItems display them in the history list view
  if (mdoProvider.HistoryItems.Count > 0)
  {
    foreach (ISoListItem item in mdoProvider.HistoryItems)
    {
      string historyString;
      historyString = item.Id + " " + item.Name;
      HistoryListView.Items.Add(historyString);
    }
  }
  //If it contains any HeadingItems display them in the heading list view
  if (mdoProvider.HeadingItems.Count > 0)
  {
    foreach (ISoListHeading item in mdoProvider.HeadingItems)
    {
      string headingString;
      headingString = item.Heading.Id + " " + item.Heading.Name;
      HeadingListView.Items.Add(headingString);
    }
  }
  //If it contains any RootItems display them in the root list view
  if (mdoProvider.RootItems.Count > 0)
  {
    foreach (ISoListItem item in mdoProvider.RootItems)
    {
      string rootString;
      rootString = item.Id + " " + item.Name;
      RootListView.Items.Add(rootString);
    }
  }
}
```

Here we have first created a group view list. This list contains 3 sets of data:

* user groups
* resource headings
* custom diary-view definitions for the user

Through this list provider, all we can get is the ID of the usergroup, the ID of the resource heading, or the ID of a custom view. By passing these IDs to different list providers we can obtain different lists. The `usergroup` table, `diaryview` table, and `diaryviewrow` table are used to obtain data for the group view list.
