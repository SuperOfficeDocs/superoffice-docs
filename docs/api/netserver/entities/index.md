---
uid: entities
title: entities
description: "Introduction to the NetServer relational database layer (Entities)."
author: AnthonyYates
so.date: 11.16.2021
keywords: data access, entity, entities, RDB
so.topic: concept
so.envir: cloud, onsite
so.client: win, web
---

# Relational database layer (Entities)

[NetServer exposes many layers][2] of its API to do the same functionality. RDB objects expose the data as neat and logical objects commonly referred to as **entities**.

Conceptually, entities are the **NetServer business objects**, such as `Contact`, `Address`, and `Appointment`. For example, when you need to work with people models, you get or create a `Person` entity; When you need to work with projects, you get or create a `Project` entity.

An entity is a **composite object**, which contains several related rows in one object. The entity handles maintaining the relationships for you.

> [!NOTE]
> Entities are business objects – not all tables have a corresponding entity.

You can use an entity's properties without worrying about the relationship details in the database. The `PostalAddress` is related to the `Contact` through an `owner_id` and `atype_idx` field, but these details are hidden by the entity:

```csharp
using SuperOffice;
using SuperOffice.CRM.Entities;
using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //Get a contact through Idx class
  Contact theContact = Contact.GetFromIdxContactId(1234);

  //Access the Name property
  string name = theContact.Name;

  //Update the postal address
  theContact.PostalAddress.City = "Oslo";

  // Saves the address row
  theContact.Save();
}
```

All Entities are provided under the **SuperOffice.CRM.Entities namespace**.

Entities consist of properties, which can be of basic data types such as `String`, `Double`, and `Int` and of complex types specific to SuperOffice such `Entities`, `Entity Collections`, `Row`, and `Rows`.

## Entity properties

Whether programming with system data types or class object data types, properties are just **data types**. In this section though, I think it is important to note the property data types you are likely to encounter from NetServer Entities.

> [!NOTE]
> Many of the business object properties bridge the divide between Entity objects and Row objects and share the same properties.

### Basic properties

In many cases, entity properties are **intrinsic data types**, such as integers and strings. For example, the Appointment Entity has simple properties like `ColorIndex` and `EndDate`.

This is the case when working with Entity lists. These are similar to entity models, but instead of collections or row objects as properties, list items contain real data values for each property.

### Complex properties

Entities are objects that may contain property values that are fetched from more than just the primary object table. In the case of a `Person` entity, the primary object table is the `Person` table. A `Person.Contact` property is a class object that is structured and populated in such a way that takes into account settings from more tables than just the `Person` table.

* **A single entity:** a logical real-world object, such as `Contact`, `Person`, or `Appointment`.
* **[Entity collections][12]:** collections of the business models, such as `ContactCollection`, `PersonCollection`, and `AppointmentCollection`.
* **[Row and Rows][1]:** properties of type XRow, where X is the name of the property, are similar to that of ADO.NET DataRows. For example, `AppointmentText` (a `TextRow` object) or `Contact.Business` (a `BusinessRow` object).
* **[TableInfo][3]:** every entity type has a TableInfo property that describes the schema of the base entity object (also categorically in the Rows layer).

![TableInfo intellisense -screenshot][img4]

> [!NOTE]
> Each entity object also has a Row property, and this is a direct link to the corresponding HDB Row object.

## Basic CRUD operations

To **create** a basic Entity, you have to use the `CreateNew` method of the `Entity` class (that you are going to create). Then you will want to populate its properties with data.

**Retrieving** data from a particular Entity in the database is done either by using the `GetFromIdx` class or the `CustomSearch`.

When data is retrieved through an Entity, it is temporarily stored (**cashed**) in the instance. This instance can be used to make changes to the data, but the database is not affected until those changes are **updated** using the `Save()` method.

**How to:**

* [Get an entity][4]
* [Create an entity][6]
* [Update an entity][8]
* [Delete an entity][10]

We show how to perform CRUD operation on an Entity and its properties in multiple ways, but the result will be the same.

### Idx classes

The following code demonstrates one way to iterate over the appointments of a person. The Person class is first instantiated by using the inner index searcher class, `IdxPersonId`. This inner index class is the equivalent of a pseudo method, Person.GetPersonById(...). Every entity object contains at least one inner Idx fetcher class. Each Idx fetcher is also exposed as a static **GetFromIdx** method, `Person.GetFromIdxPersonId`.

In the iteration, for every appointment in the `Person.Appointments collection`, if the appointment type equals type inDiary, meaning the appointment is in the persons diary (calendar), then we will write out some details of the appointment to the console window.

```csharp
using (SoSession session = SoSession.Authenticate("JR", ""))
{
  Person person = new Person.IdxPersonId(7);

  foreach (Appointment apt in person.Appointments)
  {
    //Show Diary Appointments
    if (apt.Type == AppointmentType.inDiary)
    {
      Console.WriteLine(string.Format("ID: {0}\tTask Name: {1}\tStatus: {2}\tDue Date: {3}",
          apt.AppointmentId, apt.Task.Name, apt.Status.ToString(),
          apt.DoBy.ToString()));
    }
  }
}
```

Notice how easy it is to access all of the appointments and appointment information belonging to a person. There is no need to write complex SQL queries that join multiple other tables and establish criteria, to gain access to all of the details about the appointment. All complex properties of the appointment are easily accessible.

> [!NOTE]
> The value of many entity properties is retrieved from the database when the property is accessed, not when the object itself is initialized. This is sometimes referred to as lazy fetching.

The following code demonstrates how to leverage an entity's inner index class to fetch the business object - in this case, a Contact.

```csharp
Contact contact = new Contact.IdxContactId(7);
PersonCollection people = contact.Persons;

foreach (Person person in people)
{
  Debug.Assert(person.Contact.Name == contact.Name);
}
```

Notice again how easy it is to logically drill down into the entity and intuitively access the data it contains. No complex SQL query is required to access the properties of the Contact object.

## Why use an Entity

Entities such as Contact, Person, and Sale represent business objects. The main advantage of this is that it will help you to convert a business scenario to an IT solution. Further, Entities consist of data collected from multiple tables with the appropriate relationship created, whereas in Row type it consists of data only single table, which would make it difficult for you when developing application solutions. These are some of the considerations to be noted when selecting to use Entities.

An entity is suitable for **one-at-a-time work**. Each entity will load its sub-objects greedily, so loading an entity will load its related data in one big SELECT. Entity collections should be used with care, since accessing a sub-entity of an item in the collection in a loop may trigger an extra SELECT for each item in the collection.

<!-- Referenced links -->
[1]: ../rows/index.md
[2]: ../index.md
[3]: ../rows/index.md#tableinfo-and-fieldinfo
[4]: get-entity.md
[6]: create-entity.md
[8]: update-entity.md
[10]: update-entity.md
[12]: collections.md

<!-- Referenced images -->
[img4]: media/persontableinfo.gif
