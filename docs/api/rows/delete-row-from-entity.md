---
title: delete_row_from_entity
description: Delete a Row through an Entity
author: {github-id}
so.date: 11.05.2016
keywords: 
so.topic: howto
---

# Delete a Row through an Entity

This example shows the use of the `Delete()` method to delete a Row property of a `Sale` Entity.

```csharp
using SuperOffice;
using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;

using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //Retrieve an entity
  Sale newSale = Sale.GetFromIdxSaleId(48);
  //Deleting a Currency through a Sale
  newSale.Currency.Delete();
  //Using IsDelete to check whether the Currency has being     deleted
  if (newSale.Currency.IsDeleted == true)
  {
    string test2 = "Currency has being deleted";
  }
}
```

When `Delete()` is executed above, it will delete the relevant currency row from the `Currency` table in the database.
