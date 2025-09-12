---
title: AssociateCache
uid: associate-cache
description: AssociateCache
author: Bergfrid Dias
date: 02.22.2022
keywords: cache, list, AssociateCache
content_type: concept
redirect_from: /en/api/netserver/caching/associate-cache
---

# AssociateCache

The associate cache provides the same list as the [associate list][1], but the associate cache is pulled from the cache as opposed to the associate list which is pulled from the database.

> [!TIP]
> The associate cache is a very good resource to use if your application is a performance-critical application since pulling data from the cache is much faster than pulling data from the database.

## Get the associate list

First, let’s look at how we can retrieve the associate list from the cache.

```csharp
using SuperOffice.CRM.Cache;
using SuperOffice;
using(SoSession session = SoSession.Authenticate("SAL0", ""))
{
  AssociateCache assoCache = AssociateCache.GetCurrent();
}
```

When you get the associate cache through the `GetCurrent` method of the `AssociateCache` class, it will return an object of type `AssociateCache` populated with current associates that are listed in the SuperOffice database. The returned list of associates will be categorized:

* Associate Names – the list of names of the current associates.
* Associate Persons – the list of persons that are associates.
* Associates – the list of associates with all their information.

## Methods

The returned object type `AssociateCache` implements many methods that you can use in manipulating the returned list of associates. Some of the important methods are:

* GetAssociate
* GetAssociateContact
* GetAssociateFirstName
* GetAssociateFullName
* GetAssociatePersonId
* IsAssociateRetired
* IsPersonAssociate
* ValidateAndTestAssociate

There are more, but we'll not cover all here.

## Example

The example below shows how some of these methods can be used.

```csharp
using SuperOffice.CRM.Cache;
using SuperOffice.CRM.Rows;
using(SuperOffice.SoSession session =
SuperOffice.SoSession.Authenticate("SAL0", ""))
{
AssociateCache assoCache = AssociateCache.GetCurrent();

//Get the full details of the associate ID 4 as an AssociateRow object
AssociateRow assoRow = assoCache.GetAssociate(4);

//Get the full details of the contact of associate ID 4 as a ContactRow object
ContactRow assoContact =  assoCache.GetAssociateContact(4);

//Get the first name of the associate ID 4 as a string
string assoFirstName = assoCache.GetAssociateFirstName(4);

//Get the full name of the associate ID 4 as a string
string assoFullName = assoCache.GetAssociateFullName(4);

//Get the person ID of the associate ID 4 as an int
int assoPersonID = assoCache.GetAssociatePersonId(4);

//Check if the associate ID 4 is retired.
//Returns true if the associate is retired; otherwise, false
bool isRetired = assoCache.IsAssociateRetired(4);

//Check the person ID 5 to see if the person is an associate
//Returns true if the person is an associate; otherwise, false
bool isAssociate = assoCache.IsPersonAssociate(5);

//Check if the associate ID 4 actually exists
//Returns true if the associate exists; otherwise, false
bool isAssoExists = assoCache.ValidateAndTestAssociate(4);
}
```

Using methods like above you can get some very vital information of the associates that are listed in the SuperOffice database from the cache without going to the database.

<!-- Referenced links -->
[1]: ../../contact/dev/index.md#associate
