---
uid: list-contact-interests-entity
title: How to list all selected interests for a contact
description: How to list all selected interests for a contact using entities
keywords: contact, company, interest, entity, API, ContactInterestHelper, SelectHeadingItems, SelectRootItems
author: Tony Yates
date: 05.11.2016
content_type: howto
redirect_from:
  - /en/company/howto/entity/get-interests-for-contact-entity
  - /en/api/netserver/entities/howto/company/get-interests-for-contact-entity
---

# How to list all selected interests for a contact

You can list all selected [interests][1] for a specific contact using the `ContactInterestHelper` class.

You can achieve the same with the `PersonInterestHelper` class.

The helper classes provide the functionality that combines the MDO lists and what to select (they combine entity sub-collections with MDO lists).

## Code

```csharp
using SuperOffice;
using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Lists;
using (SoSession newSession = SoSession.Authenticate("sam", "sam"))
{
  //Retrieve a Contact Based on the Contact ID
  Contact newContact = Contact.GetFromIdxContactId(10);

  //Get the list of heading items that are currently selected,
  // (have link rows to the parent entity)
  List<ISoListHeading> newLstHdItms = newContact.InterestHelper.SelectedHeadingItems;

  //Get the list of root items that are currently selected,
  // (have link rows to the parent entity)
  List<ISoListItem> newLstItms = newContact.InterestHelper.SelectedRootItems;
}
```

## Walk-through

In the code above, once we have created an instance of the `Contact` entity by using the `Contact` class, we use the contact’s `InterestHelper` to retrieve the selected interests. As shown above, we can retrieve the interest in 2 ways:

* using the `SelectHeadingItems` property
* using the `SelectRootItems` property

<!-- Referenced links -->
[1]: ../../../../company/dev/index.md#interests
