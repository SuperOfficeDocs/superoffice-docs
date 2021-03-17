---
title: get_person_from_contact_entity
description: Retrieve a list of people using entities
author: {github-id}
so.date: 05.11.2016
keywords: entity
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Retrieve a list of people using entities

The below example demonstrates the use of entities in retrieving a list of persons for a given contact.

```csharp
using SuperOffice.CRM.Entities;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("SAL0",""))
{
//retrieve the contact that the person we want belongs to
  Contact myContact = Contact.GetFromIdxContactId(21);
  //retrieve the person collection
  PersonCollection myPersons = myContact.Persons;
  if (myPersons.Count > 0)
  {
    //Iterate through the persons collection and show the name
    //in a combo box
    foreach (Person myPerson in myPersons)
    {
      cmbPersonName.Items.Add(myPerson.Firstname + " " + myPerson.Lastname);
    }
  }
}
```

In the above example, we retrieve the contact of the person we want to retrieve. Since we are retrieving an entity it contains the person that belongs to it as a property so that we can take the person to a person’s collection.

Once we have the persons in the person’s collection we can iterate through it access any of its properties. In the above example, we are accessing the `FirstName` and the `LastName` property and showing them in a combo box.

![01][img1]

<!-- Referenced links -->
[img1]: media/image001.jpg
