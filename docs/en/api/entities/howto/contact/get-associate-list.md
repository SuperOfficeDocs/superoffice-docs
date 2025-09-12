---
uid: get-associate-list-entity
title: Get the associate list
description: How to retrieve the associate list
keywords: associate, list, GetAssociateList
author: Tony Yates
date: 02.22.2022
content_type: howto
redirect_from:
  - /en/contact/howto/entity/get-associate-list
  - /en/api/netserver/entities/howto/contact/get-associate-list
---

# Get the associate list

This is the mechanism of retrieving the associates from the database.

## Example 1

```csharp
using SuperOffice.CRM.Services;
using SuperOffice.CRM.Lists;
using SuperOffice;
using(SoSession session = SoSession.Authenticate("SAL0", ""))
{
//Get the associate list as a flat list by passing the bool value true as the parameter
  ISoListProvider assoList = SoLists.GetAssociateList(true);
  if (assoList.RootItems.Count > 0)
  {
    //set the list view properties
    listView2.View = View.List;
    listView2.ShowItemToolTips = true;
    int i = 0;
    //Loop through the root items to get to the associate information
    foreach (SoListItem item in assoList.RootItems)
    {
      //Add the name and the tooltip to list view
      listView2.Items.Add(item.Name);
      listView2.Items[i].ToolTipText = item.Tooltip;
      i++;
    }
  }
}
```

In this example, the associate list is retrieved through the `GetAssociateList` method of the `SoLists` class which returns an object of type `ISoListProvider`.

You may notice that we pass the bool value True as a parameter to the `GetAssociateList` method. This means it will return a flat list without groupings. The returned items will then all appear in the `RootItems` property of the `ISoListProvider` object. The above code will not return a list grouped on the different user groups the associate belongs to.

## Example 2

In the next example let’s try out how we can get a list grouped on user groups.

```csharp
using SuperOffice.CRM.Services;
using SuperOffice.CRM.Lists;
using SuperOffice;
using(SoSession session = SoSession.Authenticate("SAL0", ""))
{
//Get the associate list as a grouped list by not providing a parameter to the method
  ISoListProvider assoList = SoLists.GetAssociateList();
  if (assoList.HeadingItems.Count > 0)
  {
    //Loop through the heading items since under the headings items only the associates will be grouped
    foreach (SoListHeading headingItem in assoList.HeadingItems)
    {
      if (headingItem.Items.Count > 0)
      {
        //Set the properties of the list view
        listView2.View = View.List;
        listView2.ShowItemToolTips = true;
        int i = 0;
        //Loop through the items of the heading items to access the individual information of the associates
        foreach (SoListItem item in headingItem.Items)
        {
          listView2.Items.Add(item.Name);
          listView2.Items[i].ToolTipText = item.Tooltip;
          i++;
        }
      }
    }
  }
}
```

In this example, the only difference from the first example is that we don’t tell NetServer explicitly to give us a flat list by not supplying a parameter for the method `GetAssociateList`. This means that all the **associates will be returned grouped** on the user groups that they belong to.

When a list of this type is returned, the associates that belong to each group will be under the `Items` property of the `HeadingItems` property of the main list. That is the reason that we have to traverse through the `HeadingItems` to get to the associates of each group.

These examples are only one usage of the [associate list][1], but there can be many more innovative designs using the provided functionality, the creativity is up to the user.

<!-- Referenced links -->
[1]: ../../../../contact/dev/index.md#associate
