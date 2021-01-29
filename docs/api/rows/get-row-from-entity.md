---
title: get_row_from_entity
description: Retrieve a row through an entity
author: {github-id}
so.date: 11.05.2016
keywords: 
so.topic: howto
---

# Retrieve a row through an entity

This example shows how to retrieve the properties of a `Currency` Row through a `Sale` Entity.

```csharp
using SuperOffice;
using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;

using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //Retrieving an Entity
  Sale newSale = Sale.GetFromIdxSaleId(2);

  //Retrieving Properties of a Row through an Entity    
  string saleCurname = newSale.Currency.Name;
  if (newSale.Currency.Deleted == 0)
  {
    string saleCurAct = "Sale Currency Active";
  }
  else
  {
    string saleCurInAct = "Sale Currency is deleted";
  }

  string saleCurDB = newSale.Currency.CurrencyTableInfo.DbName;
  string saleCurRate = newSale.Currency.Rate.ToString();
  string saleCurRank = newSale.Currency.Rank.ToString();
  string saleCurRegDate = newSale.Currency.Registered.ToString();
  string saleCurUnits = newSale.Currency.Units.ToString();
}
```
