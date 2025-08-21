---
uid: update-person-rows
title: Update a person with a new name, address, position using rows
description: How to update a person with new name, address, position using rows.
keywords: person, contact, API, rows, PersonRow, update, AddressRow
author: Tony Yates
date: 05.11.2016
content_type: howto
redirect_from:
  - /en/contact/howto/row/update-person-rows
  - /en/api/netserver/rows/howto/contact/update-person-rows
---

# Update a person with a new name, address, position using rows

Now let's focus on how we can update the person's name, position, and address using rows.

## Code

The following example uses rows exclusively.

```csharp
using SuperOffice.CRM.Rows;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  // retrieve the person row that we want to change
  PersonRow myPersonRow = PersonRow.GetFromIdxPersonId(17);

  // change the first name and the last name
  myPersonRow.Firstname = "John";
  myPersonRow.Lastname = "White";

  // change the position here we have to know the position number we want to change to
  myPersonRow.PositionIdx = 1;

  // save the person row
  myPersonRow.Save();

  // retrieve the address of the person using the address type and the person id
  AddressRow personAddressRow = AddressRow.GetFromIdxAtypeIdxOwnerId(SuperOffice.Data.AddressType.PersonPrivateAddress, 17);

  // change the address
  personAddressRow.Address1 = "No: 73";
  personAddressRow.Address2 = "West Gate Street";
  personAddressRow.Address3 = "Lexington";
  personAddressRow.City = "Kentucky";

  // save the address row
  personAddressRow.Save();
}
```

## Walk-through

We use the person row to change the name and the position of the person. Here we have assumed that we know the position ID of the position row that we want so we simply give that ID as the person’s position ID.

We changed the address of the person using an address row independent of the person row. Here we have retrieved the address row of the person using the address type and the person ID so we know that this is the address that was assigned to this person.

We have to save the person row and the address row separately since they are 2 different objects.
