---
title: How to create an Entity
uid: create_entity
description: Create entity with basic properties
author: {github-id}
so.date: 11.05.2016
keywords:
so.topic: howto
---

# How to create an Entity

To create a new instance of an Entity, we use the `CreateNew` method (of the `Entity` class that you are going to create). It must be saved using the `Save` method for the data to be stored in the database.

> [!NOTE]
> When calling `CreateNew()`, a new instance of the Entity is created with default values assigned to its properties. However, it will not be saved if you call `Save()` without changing its properties first. Therefore, to save an Entity, **you need to assign some new values to its properties**.

## Syntax

```csharp
using SuperOffice.CRM.Entities;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //Create a New Entity
  Contact newContact = Contact.CreateNew();

  //Assign values to an Entity
  newContact.Name = "Lois Lane";

  //Saving the Entity
  newContact.Save();
}
```

1. Create an Entity by calling the `CreateNew` method.
2. Assign a value to at least one of its properties.
3. Save it by calling Save().

## Create an Entity with basic properties

After you have created the Entity, you want to populate the various properties exposed by it. The types of properties in a given Entity can be different from one another. Thus populating them with data will also change depending on the property type.

In the following example, we create a `Sale` Entity and populate it with some very basic and simple properties.

```csharp
using SuperOffice;
using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;
using(SoSession newSession = SoSession.Authenticate("SAL0", ""))
{
  //create an entity
  Sale mySale = Sale.CreateNew();
  mySale.SetDefaults();

  //assign some very basic and simple properties
  mySale.Amount = 20000;
  mySale.Heading = "This is my first sale";
  mySale.Status = SuperOffice.Data.SaleStatus.Open;
  mySale.Done = SuperOffice.Data.SaleDone.NotDone;
  mySale.Earning = 10000;
  mySale.EarningPercent = 50;
  mySale.Probability = 30;

  //finally save the entity
  mySale.Save();
}
```

By *simple and basic* we mean that the properties are either system-provided simple data types like `System.String` or `System.Double` or NetServer-defined enumerations.

In a typical NetServer Entity, there are many more properties that are of very complex data types.

## See also

* [Create an Entity through an Entity][1]
* [Create a Row as a property of an Entity][2]

<!-- Referenced links -->
[1]: create-entity-in-entity.md
[2]: ../rows/create-row-in-entity.md
