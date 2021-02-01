---
title: update_entity
description: How to update an Entity
author: {github-id}
so.date: 11.05.2016
keywords: 
so.topic: howto
---

# Update a basic property of an Entity

Before updating an Entity, it must be retrieved by using the `Idx` class.

Updating a **basic property** of an Entity means changing the values that are stored in properties of basic data types, such as integer or string.

```csharp
using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;
using SuperOffice;

using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //Retriving a Sale using the index of a Sale
  Sale newSale = Sale.GetFromIdxSaleId(2);

  //Update Sale properties directly
  newSale.ActiveLinks = 2;
  newSale.Amount = 100000.0;
  newSale.Earning = 50000;
  newSale.EarningPercent = 15;
  newSale.Heading = "Test edited for testing.";
  newSale.Status = SuperOffice.Data.SaleStatus.Sold;

  if (newSale.IsDirty == true)
  {
    //Saving the Sale Entity
    newSale.Save();
  }
}
```

1. Get an Entity from the `sale` table with row ID 2.
2. Update properties of the sale (see below)
3. Set the `IsDirty` property to true if there is any change made to that Entity.
4. Call `Save()` to update any changed data in the database.

| Property | Type |
|---|---|
| ActiveLinks | Unsigned Integer |
| Amount | Double |
| Earning | Double |
| EarningPercentage | Double |
| Heading | String |
| Status | SuperOffice.Data.SaleStatus |

## See also

* [Update an Entity through an Entity][1]
* [Update a Row through an Entity][2]

<!-- Referenced links -->
[1]: update-entity-in-entity.md
[2]: ../rows/update-row-in-entity.md
