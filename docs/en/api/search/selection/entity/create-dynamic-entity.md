---
title: Creating a dynamic selection using entities
uid: create_dynamic_selection_entity
description: Creating a dynamic selection using entities
author: SuperOffice Product and Engineering
date: 05.11.2016
keywords: search
content_type: howto
redirect_from: /en/api/netserver/search/selection/entity/create-dynamic-entity
---

# Creating a dynamic selection using entities

As the word implies, a dynamic selection is **a selection that is bound to change dynamically** and it’s **based on search criteria** and not just static members.

A typical criterion would be "Add all contacts with a specific business type". This would cause the member count of this selection to increase each time a new contact is added to the database that matches the business type specified as a search criterion for this selection. You may have as many search criteria as you want.

Here, we'll show you how to do this [using entities][1].

## Code

```csharp
using SuperOffice.CRM.Entities;
using SuperOffice.CRM.ArchiveLists;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("SAL0",""))
{
//create a new selection
  Selection mySelection = Selection.CreateNew();
  mySelection.SetDefaults();

  //set the selection type to Dynamic
  mySelection.Seltype = 1;

  //we will include the first person from each company in our selection
  mySelection.IncludePerson = 1;

  //give it a name
  mySelection.Name = "Dynamic selection with couple of criteria";

  //save the selection
  mySelection.Save();

  //create a restriction array since we are going to give more than one
  // restriction to add members to our selection
  ArchiveRestrictionInfo[] restrictions = new ArchiveRestrictionInfo[2];

  //specify the first restriction
  restrictions[0] = new ArchiveRestrictionInfo("business", "is", "4");

  //specify the second restriction. Here we are restricting the contact
  //to the contacts that starts with “c”
  restrictions[1] = new ArchiveRestrictionInfo("name", "begins", "c");

  //to store our selection restriction we need a restriction storage
  IRestrictionStorage storage = RestrictionStorageFactory.GetProvider(RestrictionCriteriaStorage.StorageType);

  //save the restriction using the provider name and the selection ID
  //as the storage key
  storage.SaveRestrictions(SelectionDynamicProvider.ProviderName, "selection=" + mySelection.SelectionId.ToString(),restrictions);
}
```

## Walk-through

In the above example, we have created a selection using entities and then we have used the providers to add the restriction for the members that should be added to the created selection. The creation of the selection is pretty straight forward so we will just explain how to add search criteria.

We have created an array of `ArchiveRestriontionInfo` objects since we will add more than one restriction. When you are specifying the restriction, you have to specify the criteria using 3 parameters:

* the name of the field
* the operator
* the value

Here, we have said give us the contacts with a name starting with the letter c and give us the contacts in the business that corresponds to row ID 4 of the `business` table.

Once we have the restrictions ready, we need to store them against the selection to tell the system that this restriction is for a particular selection. We can do this with a `RestrictionCriteriaStorage` provider. We can save our restrictions using the `SaveRestriction` method. In the `SaveRestriction` method, the second parameter will act as the key. If you want you can access this criterion using this key.

Now that we have completed the job, you can open SuperOffice and view this selection. [See screenshot of the dialog.][2]

<!-- Referenced links -->
[1]: ../../../entities/index.md
[2]: ../dynamic-selections.md
