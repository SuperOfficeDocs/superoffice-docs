---
title: Delete an Entity through an Entity
uid: delete_entity_from_entity
description: Delete an Entity through an Entity
author: {github-id}
so.date: 11.05.2016
keywords:
so.topic: howto
---

# Delete an Entity through an Entity

Properties of Entities can themselves be Entities. Since we can access properties of such an entity, we can also delete the Entity.

This example shows the use of the `Delete()` method to delete an Entity property of a `Sale` Entity.

```csharp
using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //Retrieve an entity
  Sale newSale = Sale.GetFromIdxSaleId(48);

  //Deleting a Contact through a Sale
  newSale.Contact.Delete();

  //Using IsDelete to check whether the Contact has been deleted
  if (newSale.Contact.IsDeleted == true)
  {
    string test2 = "Contact has been deleted";
  }
}
```

The `IsDelete` property in the Contact Entity is used to check whether the Contact Entity has been deleted. If the Entity is deleted, the value of the property will be set to "true".

## See also

* [Delete an Entity][1]
* [Delete a Row through an Entity][2]

<!-- Referenced links -->
[1]: delete-entity.md
[2]: ../rows/delete-row-from-entity.md
