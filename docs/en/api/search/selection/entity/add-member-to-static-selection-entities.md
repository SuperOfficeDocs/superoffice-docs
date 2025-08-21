---
title: How to add members to a static selection using entities layer
uid: add_members_static_selection_entities
description: How to add members to a static selection using entities
author: SuperOffice Product and Engineering
date: 05.11.2016
keywords: search, entities
content_type: howto
redirect_from:
  - /en/api/search/selection/entity/index
  - /en/api/netserver/search/selection/entity/add-member-to-static-selection-entities
  - /en/api/netserver/search/selection/entity
---

# How to add members to a static selection using entities layer

The example demonstrates the use of entities to achieve the task.

## Code

```csharp
using SuperOffice.CRM.Security;
using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;
using SuperOffice;
using(SoSession session = SoSession.Authenticate("SAL0", ""))
{
  //retrieve the contact that owns the persons we want to add as members
  //to our static selection
  Contact myContact = Contact.GetFromIdxContactId(21);

  //retrieve the selection that we want to add members to
  Selection staticSelection = Selection.GetFromIdxSelectionId(65);

  //lets loop through the persons of the contact and the them to the
  // selection as its members
  int i = 0;
  if (myContact.Persons.Count > 0)
  {
    foreach (Person myPerson in myContact.Persons)
    {
      //create a new selection member row
      SelectionMemberRow newRow =
      SelectionMemberRow.CreateNew();

      //set the default values
      newRow.SetDefaults();

      //assign the contact ID
      newRow.ContactId = myContact.ContactId;

      //assign the person ID
      newRow.PersonId = myPerson.PersonId;

      //add rows of the selection member rows collection one by
      // one to the retrieved static selection entity
      staticSelection.SelectionMembers.Add(newRow);
      i++;
    }
  }
  //finally save the selection entity
  staticSelection.Save();
}
```

## Walk-through

Here we have retrieved the contact entity that the persons that we want to add as members to the static selection belong to.

Now we can loop through the person collection of the contact entity and add the persons one by one as members of the static selection.

This example only adds persons from one contact, but if you want you may add persons from many contacts as members of a static selection. Also, you can notice the contact ID and the person ID has not been hard-coded, but if you want to this is also a possibility.

[!include[ALT](../includes/note-hardcoding-id.md)]
