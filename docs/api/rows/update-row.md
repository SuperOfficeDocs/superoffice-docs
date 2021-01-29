---
title: update_row
description: SuperOffice database update row with basic properties
author: {github-id}
so.date: 11.05.2016
keywords: 
so.topic: howto
---

# Update basic properties of a Row

Before updating a Row, it must be retrieved by using the `Idx` class.

This example shows how the properties of a Row are updated.

```csharp
using SuperOffice;
using SuperOffice.CRM.Rows;

using(SoSession newSession = SoSession.Authenticate("SAL0", ""))
{
  //Create a New Row
  ContactRow myContactRow = ContactRow.GetFromIdxContactId(125);

  //Update the properties of the ContactRow
  myContactRow.Name = "Daisy Susan";
  myContactRow.CountryId = 12;
  if (myContactRow.IsDirty)
  {
    myContactRow.Save();
  }
}
```

1. Get a row from the `contact` table with row ID 125.
    If such a row does not exist, the instance of the `ContactRow` will be assigned to null.
2. Update the `Name` and `CountryId` of the `ContactRow`.
3. Set the `IsDirty` property to true if there is any change made to that Row.
4. Call `Save()` to update any changed data in the database.
