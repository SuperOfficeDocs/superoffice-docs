---
title: delete_row_from_entity
description: Delete a Row through an Entity
author: {github-id}
so.date: 11.05.2016
keywords:
so.topic: howto
---

# Delete a Row through an Entity

We are aware that some properties of an Entity are of Row type. Hence, by using the `Delete` method we can delete a Row as well. In this case, it will delete an entire row from the database.

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

  //Using IsDelete to check whether the Currency has being deleted
  if (newSale.Currency.IsDeleted == true)
  {
    string test2 = "Currency has being deleted";
  }
}
```

When `Delete()` is executed above, it will delete the relevant currency row from the `Currency` table in the database.

## See also

* [Delete an Entity][1]
* [Delete a Row through an Entity][2]

<!-- Referenced links -->
[1]: ../entities/delete-entity.md
[2]: ../entities/delete-entity-from-entity.md
