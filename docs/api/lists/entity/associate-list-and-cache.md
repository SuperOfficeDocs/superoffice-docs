---
title: Associate list and cache
uid: associate_list_and_cache
description: Associate list and cache
author: {github-id}
so.date: 05.11.2016
keywords:
so.topic: concept
---

# Associate list and cache

In NetServer when you have a session, the session cache will contain a special cache entry named the **associate cache**. There all the associates listed in the SuperOffice database can be accessed through the cache, which is much faster than retrieving the associates from the database.

The **associate list** is an MDO list type that you can retrieve from the database.

This section compares how the same list can be retrieved from the database and the cache, and the advantages of the two approaches.

## Associate list

The associate list represents a list of all the associates in the SuperOffice database. This is the mechanism of retrieving the associates from the database.

Let’s look at some examples. They are only one usage of the associate list, but there can be many more innovative designs using the provided functionality, the creativity is up to the user.

### Example 1

```csharp
using SuperOffice.CRM.Services;
using SuperOffice.CRM.Lists;
using SuperOffice;
using(SoSession session = SoSession.Authenticate("SAL0", ""))
{
//get the associate list as a flat list by passing the bool
//value true as the parameter
  ISoListProvider assoList = SoLists.GetAssociateList(true);
  if (assoList.RootItems.Count > 0)
  {
    //set the list view properties
    listView2.View = View.List;
    listView2.ShowItemToolTips = true;
    int i = 0;
    //loop through the root items to get to the associate
    //information
    foreach (SoListItem item in assoList.RootItems)
    {
      //add the name and the tooltip to list view
      listView2.Items.Add(item.Name);
      listView2.Items[i].ToolTipText = item.Tooltip;
      i++;
    }
  }
}
```

In this example, the associate list is retrieved through the `GetAssociateList` method of the `SoLists` class which returns an object of type `ISoListProvider`.

You may notice that we pass the bool value True as a parameter to the `GetAssociateList` method. This means it will return a flat list without groupings. The returned items will then all appear in the `RootItems` property of the `ISoListProvider` object. The above code will not return a list grouped on the different user groups the associate belongs to.

### Example 2

In the next example let’s try out how we can get a list grouped on user groups.

```csharp
using SuperOffice.CRM.Services;
using SuperOffice.CRM.Lists;
using SuperOffice;
using(SoSession session = SoSession.Authenticate("SAL0", ""))
{
//get the associate list asa grouped list by not providing a
  //parameter to the method
  ISoListProvider assoList = SoLists.GetAssociateList();
  if (assoList.HeadingItems.Count > 0)
  {
    //loop through the heading items since under the headings items
    //only the associates will be grouped
    foreach (SoListHeading headingItem in assoList.HeadingItems)
    {
      if (headingItem.Items.Count > 0)
      {
        //set the properties of the list view
        listView2.View = View.List;
        listView2.ShowItemToolTips = true;
        int i = 0;
        //loop through the items of the heading items to
        //access the individual information of the

        //associates
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

## Associate cache

The associate cache provides the same list as the associate list, but the associate cache is pulled from the cache as opposed to the associate list which is pulled from the database.

> [!TIP]
> The associate cache is a very good resource to use if your application is a performance-critical application since pulling data from the cache is much faster than pulling data from the database.

First, let’s look at how we can retrieve the associate list from the cache.

```csharp
using SuperOffice.CRM.Cache;
using SuperOffice;
using(SoSession session = SoSession.Authenticate("SAL0", ""))
{
  AssociateCache assoCache = AssociateCache.GetCurrent();
}
```

When you get the associate cache through the `GetCurrent` method of the `AssociateCache` class, it will return an object of type `AssociateCache` populated with current associates that are listed in the SuperOffice database. The returned list of associates will be categorized with the following categories:

* Associate Names – the list of names of the current associates.
* Associate Persons – the list of persons that are associates.
* Associates – the list of associates with all their information.

The returned object type `AssociateCashe` implements many methods that you can use in manipulating the returned list of associates. Some of the important methods are:

* GetAssociate
* GetAssociateContact
* GetAssociateFirstName
* GetAssociateFullName
* GetAssociatePersonId
* IsAssociateRetired
* IsPersonAssociate
* ValidateAndTestAssociate

There are more, but we'll not cover all here.

The example below shows how some of these methods can be used.

```csharp
using SuperOffice.CRM.Cache;
using SuperOffice.CRM.Rows;
using(SuperOffice.SoSession session =
SuperOffice.SoSession.Authenticate("SAL0", ""))
{
AssociateCache assoCache = AssociateCache.GetCurrent();
//get the full details of the associate ID 4 as an Associate Row object
AssociateRow assoRow = assoCache.GetAssociate(4);
//get the full details of the contact of associate ID 4 as a Contact Row object
ContactRow assoContact =  assoCache.GetAssociateContact(4);
//get the first name of the associate ID 4 as a string
string assoFirstName = assoCache.GetAssociateFirstName(4);
//get the full name of the associate ID 4 as a string
string assoFullName = assoCache.GetAssociateFullName(4);
//get the person ID of the associate ID 4 as a int
int assoPersonID = assoCache.GetAssociatePersonId(4);
//check the associate ID 4 is retired or not this will return bool value
//true if the associate is retired and false otherwise
bool isRetired = assoCache.IsAssociateRetired(4);
//check the person ID 5 to see if the person is an associate this will return
//true if the person is an associate and false otherwise
bool isAssociate = assoCache.IsPersonAssociate(5);
//this method will check if the associate ID 4 actually exists this will
//return true if the associate exists and false otherwise
bool isAssoExists = assoCache.ValidateAndTestAssociate(4);
}
```

Using methods like above you can get some very vital information of the associates that are listed in the SuperOffice database from the cache without going to the database.
