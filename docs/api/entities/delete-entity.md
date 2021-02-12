---
title: delete_entity
description: Delete an entity
author: {github-id}
so.date: 11.05.2016
keywords:
so.topic: howto
---

# Delete an Entity

To delete an Entity, we have to use the `Delete()` method of that entity.

> [!NOTE]
> Deleting an Entity will not delete any Entities or Rows that are parts of its properties.

```csharp
using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;
using SuperOffice;
using (SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //Retrieve an entity
  Sale newSale = Sale.GetFromIdxSaleId(49);

  //Deleting the Entity
  newSale.Delete();

  //Checking whether the entity has being deleted
  if (newSale.IsDeleted == true)
  {
    string test = "The sale has been deleted";
  }
}
```

Before we delete any entity, we have to retrieve it. Once an Entity is retrieved, we can simply use the `Delete()` method and remove that particular Entity from the database.

## See also

* [Delete an Entity through an Entity][1]
* [Delete a Row through an Entity][2]

<!-- Referenced links -->
[1]: delete-entity-from-entity.md
[2]: ../rows/delete-row-from-entity.md
