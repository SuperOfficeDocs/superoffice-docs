---
title: get_entity
description: How to retrieve an Entity
author: {github-id}
so.date: 11.05.2016
keywords:
so.topic: howto
---

# How to retrieve an Entity

We need to retrieve an Entity for several purposes, viewing the properties of an Entity is one such purpose.

## Syntax

The following example shows the use of the `GetFromIdx` function to retrieve an Entity.

```csharp
using SuperOffice.CRM.Entities;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //Retrieving a Property of PersonEntity
  Person newPerson = Person.GetFromIdxPersonId(20);
  string personName = newPerson.Firstname;
}
```

## Retrieve an Entity with basic properties

Retrieving basic properties of a `Contact` Entity implies obtaining properties that are neither Entities nor Rows.

The following example demonstrates how to retrieve properties of **basic data type** of an Entity.

```csharp
using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //Retrieving an Entity
  Contact newContact = Contact.GetFromIdxContactId(11);

  //Retrieving Basic properties of an Entity
  string aInterests = newContact.ActiveInterests.ToString();
  string depart = newContact.Department;
  string kName = newContact.Kananame;
  string cName = newContact.Name;
  string cNum1 = newContact.Number1;
  string cNum2 = newContact.Number2;
  string orgNum = newContact.OrgNr;
  string cRegDate = newContact.Registered.ToString();
}
```

Here, the `Registered` property is of Datetime data type. All the other properties (Department, Kananame, Name, Number1, Number2, OrgNr) are of type String.

## See also

* [Retrieve an Entity property through an Entity][1]
* [Retrieve a row through an Entity][2]

<!-- Referenced links -->
[1]: get-entity-from-entity.md
[2]: ../rows/get-row-from-entity.md
