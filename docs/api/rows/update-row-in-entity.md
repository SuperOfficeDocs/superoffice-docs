---
title: update_row_in_entity
description: Update a Row through an Entity
author: {github-id}
so.date: 11.05.2016
keywords: 
so.topic: howto
---

# Update a Row through an Entity

These examples show how to update the properties of a Row through an Entity. As in the case of creating or retrieving and assigning Entity properties to the Sale entity, there are two methods of doing this.

## Example 1

Here, the properties of the Currency are accessed through the `Sale` Entity. When modifications are made and the sale is saved, a new `Currency` row in the `Currency` table will be created.

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

## Example 2

Create `CurrencyRow` object and then assign it to the `Currency` property of the `Sale` Entity.

```csharp
using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;
using SuperOffice;

using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //Retriving a Sale using the index of a Sale

  Sale newSale = Sale.GetFromIdxSaleId(2);
  //Creating a Currency Row and assigning values
  CurrencyRow newCurrency = CurrencyRow.CreateNew();
  newCurrency.Name = "SAD";
  newCurrency.Rank = 5;
  newCurrency.Tooltip = "Created for testing";
  newCurrency.Rank = 23;
  newCurrency.Units = 52.25;

  //Assigning the new Currency to sale
  newSale.Currency = newCurrency;

  //Saving the Sale Entity
  newSale.Save();
}
```

This method is used given a whole new currency type that is a lot different from the existing one. When saving the Sale Entity all changes made to the Currency Row will also be saved.

The alternative is this notation used in example 1:

```csharp
newSale.Currency.Name = "DAS";
```

## See also

* [Update a basic property of an Entity][1]
* [Update an Entity through an Entity][2]

<!-- Referenced links -->
[1]: ../entities/update-entity.md
[2]: ../entities/update-entity-in-entity.md
