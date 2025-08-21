---
uid: update-person-entity
title: Update a person with a new name, address, position using entities
description: Update a person with new name, address, position using entities
keywords: person, contact, entity, API
author: Tony Yates
date: 05.11.2016
content_type: howto
redirect_from:
  - /en/contact/howto/entity/update-person-entity
  - /en/api/netserver/entities/howto/contact/update-person-entity
---

# Update a person with a new name, address, position using entities

Let's discuss how we can update the name, address, and position of an existing person using entities.

## Code

```csharp
using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
//retrieve the person you want to change to a person entity
  Person myPerson = Person.GetFromIdxPersonId(17);

  //change the first name and last name
  myPerson.Firstname = "John";
  myPerson.Lastname = "White";

  //retrieve a person position row that you want to
  //assign as the person position to a row object
  PersPosRow personPosition = PersPosRow.GetFromIdxPersPosId(1);

  //assign retrieved position row as the position of the person
  myPerson.Position = personPosition;

  //fill in the basic properties of the address row
  myPerson.Address.Address1 = "No: 73";
  myPerson.Address.Address2 = "West Gate Street";
  myPerson.Address.Address3 = "Lexington";
  myPerson.Address.City = "Kentucky ";

  //finally save the person entity
  myPerson.Save();
}
```

## Walk-through

In the above example, we have used a mix of entities and rows. We have taken rows here since some of the properties that are exposed by the person entity are rows. For example, the position property of the person is exposed as a row.

We first change the name of the person we want and then retrieve a position row and assign the retrieved row as the position of the person. We have changed the address by accessing the properties of the address row through the `person` property itself.

When we finally save the `person` property, the address that was assigned to the person will get updated with the new values we specified.
