---
title: create_row_in_entity
description: Create a row as a property of another entity
author: {github-id}
so.date: 11.05.2016
keywords: 
so.topic: howto
---

# Create a Row as a property of another entity

An Entity can have properties that are of the type Row. A Row object contains properties of basic data types.

These examples show how to create a Row object and assign it to a property of an Entity.

## Example 1

Create and modify the properties of a `ReasonRow` object through the `Sale` Entity.

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

## Example 2

Create `CurrencyRow` object and then assign it to the `Currency` property of the `Sale` Entity.

```csharp
using SuperOffice;
using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;

using(SoSession newSession = SoSession.Authenticate("SAL0", ""))
{
  //Creating a new Sale Entity
 Sale newSale = Sale.CreateNew();
  newSale.SetDefaults();

  //Creating a new Currency Row and assigning it values
  CurrencyRow newCurrency = CurrencyRow.CreateNew();
  newCurrency.SetDefaults();

  newCurrency.Name = "Riyal";
  newCurrency.Rank = 5;
  newCurrency.Units = 52.25;
  newSale.Currency = newCurrency;

 //Saving the Sale Entity
  newSale.Save();
}
```

When calling `Save()`, the `Sale` Entity instance will be saved along with a new row being added to the `Currency` table with its name (Riyal), rank (5), and units (52.25) fields with given values. The rest of the columns will have default values.

## See also

* [How to create an Entity][1]
* [Create an Entity through an Entity][2]

<!-- Referenced links -->
[1]: ../entities/create-entity.md
[2]: ../entities/create-entity-in-entity.md
