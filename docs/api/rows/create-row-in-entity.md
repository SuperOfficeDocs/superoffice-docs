---
title: create_row_in_entity
description: Create a row as a property of another entity
author: {github-id}
so.date: 11.05.2016
keywords: 
so.topic: howto
---

# Create a Row as a property of another entity

This example shows how to create a Row object and assign it to a property of an Entity.

```csharp
using SuperOffice;
using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;

using(SoSession newSession = SoSession.Authenticate("jr", "jr"))
{

  //Creating a new Sale Entity
  Sale newSale = Sale.CreateNew();
  newSale.SetDefaults();

  //creating a row through the Sale Entity and assigning values
  newSale.Reason = ReasonRow.CreateNew();
  newSale.Reason.Name = "Resource Utilization";
  newSale.Reason.Rank = 10;

  //Saving the Sale Entity
  newSale.Save();
}
```

1. Create a new `Reason` through the newly created `Sale` Entity.
2. Assign the row to the `Reason` property of the Entity instance.
3. Call the `Save` method to save the `Sale` Entity instance and at the same time add a new row to the `Reason` Table.

> [!NOTE]
> You do not need to explicitly create a new Row when using an Entity property. The Entity will create a new blank Row for you automatically.
