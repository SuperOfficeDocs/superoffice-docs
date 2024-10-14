---
uid: crmscript-price-list
title: Price lists
description: How to work with price lists in CRMScript.
keywords: sale, quote, product, price list, QuoteAgent
author: Bergfrid Skaara Dias
date: 06.12.2023
version: 10
topic: howto
---

# Price lists

## Retrieve price lists

### NSPriceList GetPriceList(Integer priceListId)

Fetch a specific price list by its ID.

```crmscript!
NSQuoteAgent qa;

NSPriceList priceList = qa.GetPriceList(2);

printLine(priceList.GetName() + ": " + priceList.GetCurrency());
```

### Get multiple price lists from quote connection

You've got several variants of `GetPriceList()`, which all return `NSPriceList[]` and take the **ID of a quote connection** as the 1st argument.

| Method | Currency | Only active | Include upcoming/expired |
|:--|:--|:-:|:--:|
| GetActivePriceLists | String | x | |
| GetActivePriceListsByCurrencyId | Integer (ID) | x | |
| GetAllPriceLists | String | | x |
| GetAllPriceListsByCurrencyId | Integer (ID) | | x |

```crmscript!
NSQuoteAgent qa;

NSPriceList[] priceLists = qa.GetActivePriceLists(1, "NOK");

for(Integer i = 0; i < priceLists.length(); i++) {
  printLine(priceLists[i].GetName());
}
```

## Create price list

```crmscript!
DateTime now;
NSQuoteAgent qa;

NSPriceList priceList = qa.CreateDefaultPriceList();

priceList.SetName("gardening tools fall 2020");
priceList.SetValidFrom(now);
priceList.SetValidTo(now.moveToYearEnd());

priceList = qa.SavePriceList(priceList);

printLine(priceList.GetPriceListId().toString());
```

> [!TIP]
> By default, the new price list will be valid "forever", with the validity period set using the max and min value of the DateTime type.

## Update price list

1. Fetch the NSPriceList object with the agent.
2. Call the appropriate *set* methods.
3. Call `SavePriceList()`.

## Delete price list

```crmscript
Integer priceListId = 99;
NSQuoteAgent qa;
qa.DeletePriceList(priceListId);
```

## Reference

### Frequently used price list fields

| Field          | Description                               |
|:---------------|:------------------------------------------|
| pricelist_id   | ID                                        |
| Name           | Label for UI                              |
| Description    |                                           |
| CurrencyId     | The currency of the list                  |
| ValidFrom      | The date at which the list becomes valid  |
| ValidTo        | The last date the list is valid           |
| IsActive       | Link to product information web page      |
| IsERPCopy      | Whether it's a cache and can't be changed in CRM |

For a complete list of fields, see the [database reference][2].

<!-- Referenced links -->
[2]: ../../../../database/tables/pricelist.md
