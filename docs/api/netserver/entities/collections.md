---
title: Collections
uid: entity_collections
description: Entity collections
author: {github-id}
keywords:
so.topic: howto
# so.envir:
# so.client:
---

# Collections

Some Entities consist of a collection of Entities as one of its properties.
The Entity layer exposes us to Entity collections as well.

For example, the `Contact` Entity has a property called `Persons`, which is a **Collection of Person Entities**.

There are two major types of Collections: Collection of Entity types and Collection of Row types.

## Create

```csharp
using SuperOffice;
using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;
using(SoSession newSession = SoSession.Authenticate("SAL0", ""))
{
  //Creating a new Contact Entity and assigning values to some of its properties
  Contact newContact = Contact.CreateNew();
  newContact.SetDefaults();
  newContact.Name = "EuroCenter DDC";
  newContact.Department = "Editing";

  //Creating a Person Entity and adding it to the   Collection
  Person newPerson = Person.CreateNew();
  newPerson.SetDefaults();
  newPerson.Firstname = "Mark";
  newPerson.Lastname = "Anthony";

  //Creating an Appointment Entity
  Appointment newAppointment = Appointment.CreateNew();
  newAppointment.SetDefaults();
  newAppointment.Alarm = 7;

  //Adding the Appointment Entity to the Appointment Collection in the Person Entity
  newPerson.Appointments.Add(newAppointment);

  //Adding the Person to the Persons Collection in the Contact Entity
  newContact.Persons.Add(newPerson);

  //Saving the Entity
  newContact.Save();
}
```

First, we create a new `Contact` Entity and assign values to some of its properties.

`Persons` is a property of the `Contact` Entity of type `PersonCollection` (a collection of Person Entities). Similarly, `AppointmentCollection` is a collection of Appointment Entities.

In the example, we create a new `Appointment` Entity and assign values to some of its basic properties just as we did with the `Person` Entity.

Then we create a link between the appointment and the person.

The `Person` Entity can contain properties of Entities Collection type, Appointments is one such property. Hence, we can add the newly created Appointment to the Appointments property of the Person Entity.

Alternatively:

```csharp
//another method of creating an Entity and adding to the Collection
newPerson.Appointments.Add(Appointment.CreateNew());
newPerson.Appointments[0].SetDefaults();
newPerson.Appointments[0].Alarm = 7;
```

Here, several tables get updated. When the new `Contact` Entity is saved, a new row will be added to the `contact` table in the database. New rows will also be added to the `appointment` and `person` tables, which will be linked to the entry in the Contact table by the `contact_id` field in each table. This cascade of events happens when we call `Save()`.

## Retrieve elements from a Collection of Entity types

To retrieve elements of a Collection, we can use the `GetFromIdx` function.

```csharp
using SuperOffice;
using SuperOffice.CRM.Entities;
using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //Retrieving a Property of PersonEntity
  PersonCollection personCollection = PersonCollection.GetFromIdxFirstname("Linda");
  string[] perFirstName = new string[personCollection.Count];
  int i = 0;
  foreach (Person getPerson in personCollection)
  {
    //Retrieving First and Last names from the Collection
    perFirstName[i] = getPerson.Firstname + " " + getPerson.Lastname;
    i = i + 1;
  }
}
```

Here we use `GetFromIdxFirstname()` to retrieve a Collection of Person Entities with Firstname like "Linda".

## Delete

Using the `Delete` method, it is possible to delete an Entity collection. However, the relevant data contained in it will not be deleted from the database. Only the references that link the Entity to the Entity Collection will be deleted.

Here we delete the references to the Entities of an Entity Collection.

```csharp
using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //Retrieve an entity
  Contact newContact = Contact.GetFromIdxContactId(25);

  //Deleting an Entity Collection through a Contact
  newContact.Persons.Delete();
}
```

If we wish to delete a particular Entity of the collection, here's how:

```csharp
newContact. Persons[0].Delete();
```

### Deleting Rows vs. an Entity Collection

Rows, which consist of Row types, are another type which can be a property of an Entity. Therefore, it is possible to use the `Delete` method to delete such a set of Rows. The difference is that when Rows are deleted, it is removed from the database, whereas when an Entity Collection is deleted it is not.

```csharp
using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //Retrieve an entity
  Contact newContact = Contact.GetFromIdxContactId(25);

  //Deleting an Rows Collection through a Contact
  newContact.Emails.Delete();
}
```

If you wish to delete a particular Row of the collection, here's how:

```csharp
newContact.Emails[0].Delete();
```
