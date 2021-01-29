---
title: update_row_in_entity
description: Update a Row through an Entity
author: {github-id}
so.date: 11.05.2016
keywords: 
so.topic: howto
---

# Update a Row through an Entity

This example shows how to update the properties of a Row through an Entity.

```csharp
using SuperOffice;
using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;
using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //Retrieving a Sale using the index of a Sale
  Sale newSale = Sale.GetFromIdxSaleId(2);
  //Changing the values of the Currency Row through the Sale entity
  newSale.SetDefaults();
  newSale.Currency.Name = "DAS";
  newSale.Currency.Rank = 4;
  newSale.Currency.Tooltip = "Created for testing";
  newSale.Currency.Units = 65.32;
  if (newSale.IsDirty == true)
  {
    //Saving the Sale Entity
    newSale.Save();
  }
}
```

You may use the above code if you want to change a limited number of properties of a `Currency` property in the `Sale` Entity.

Here, the properties of the Currency are accessed through the `Sale` Entity. When modifications are made and the sale is saved, a new `Currency` row in the `Currency` table will be created.
