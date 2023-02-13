---
title: Create a Row with basic properties
uid: create_row
description: Create row with basic properties
author: {github-id}
so.date: 11.05.2016
keywords:
so.topic: howto
---

# Create a Row with basic properties

This example shows how to create a Row and populate some very basic properties.

```csharp
using SuperOffice;
using SuperOffice.CRM.Rows;
using(SoSession newSession = SoSession.Authenticate("SAL0", ""))
{
  //Create a New Row
  ContactRow myContactRow = ContactRow.CreateNew();
  myContactRow.SetDefaults();

  //Assign values to its basic properties
  myContactRow.Name = "SuperOffice ASA";
  myContactRow.Department = "ABC Dept";

  //Retrieve a country row and assign the country id of that row
  CountryRow myCountry = CountryRow.GetFromIdxName("Algeria");
  myContactRow.CountryId = myCountry.CountryId;

  // Finally save the row
  myContactRow.Save();
}
```

1. Get a `CountryRow` using the `IdxName` method.
2. Get `countryId` from the `countryRow`.
3. Assign a value to the `CountryId` property of the `ContactRow`.

You can even assign an integer value to the property directly.

> [!NOTE]
> If you assign an ID of a non-existing `countryRow` to the `CountryId` property of the `ContactRow`, no exception will be thrown and that value will be stored in the database. But when you retrieve the `CountryId` property through `ContactEntity`, you will always get 0 if it’s a non-existing row.
