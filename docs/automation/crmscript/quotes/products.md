---
uid: crmscript_products
title: Products and price lists 
author:
so.date:
keywords:
so.topic:
---

# Products and price lists

Each product belongs to a single price list. A price list can either be cached from an ERP system or set up in SuperOffice CRM.

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

| Method                          | Currency     | Only active | Include upcoming/expired |
|:--------------------------------|:-------------|:-----------:|:------------------------:|
| GetActivePriceLists             | String       | x           |                          |
| GetActivePriceListsByCurrencyId | Integer (ID) | x           |                          |
| GetAllPriceLists                | String       |             | x                        |
| GetAllPriceListsByCurrencyId    | Integer (ID) |             | x                        |

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

## Fetch products

### NSProduct GetProduct(Integer quoteConnectionId, String eRPProductKey)

To call `GetProduct()`, you need the ID of both the quote connection and of the product itself.

```crmscript
NSQuoteAgent qa;
NSProduct product = qa.GetProduct(1,"3412-20");
```

### NSProduct GetProductFromDbId(Integer productId)

A variant of `GetProduct()` that lets you retrieve by database ID.

```crmscript
NSQuoteAgent qa;

NSProduct product = qa.GetProductFromDbId(3);

printLine(product.GetName() + "\t" + product.GetCode());
```

## Create product

```crmscript!
NSQuoteAgent qa;
NSProduct product = qa.CreateDefaultProduct();

product.SetName("bulb planter");
product.SetERPPriceListKey("5");

product = qa.SaveProduct(product);

printLine(product.GetProductId().toString());
```

## Update product

1. Fetch the NSProduct object with the agent.
2. Call the appropriate *set* methods.
3. Call `SaveProduct()`.

## Delete product

```crmscript
Integer productId = 99;
NSQuoteAgent qa;
qa.DeleteProduct(productId);
```

### Remove from database

```crmscript
Integer productId = 88;
NSQuoteAgent qa;
qa.RemoveProduct(productId);
```

## Reference

### Frequently used product fields

| Field          | Description                               |
|:---------------|:------------------------------------------|
| product_id     | ID                                        |
| PriceListId    | the price list the product belongs to     |
| Name           | label for UI                              |
| Description    |                                           |
| Code           | the product code or article number in the product supplier system |
| PriceUnit      | what kind of amount the price pertains to |
| IsSubscription | whether it's a recurring offer            |
| Url            | link to product information web page      |
| VAT            | percentage                                |
| UnitListPrice  | the basic price from which the discount is computed from |
| InAssortment   | whether currently offered or out-of-stock/discontinued |

For a complete list of fields, see the [database reference][1].

### Frequently used price list fields

| Field          | Description                               |
|:---------------|:------------------------------------------|
| pricelist_id   | ID                                        |
| Name           | label for UI                              |
| Description    |                                           |
| CurrencyId     | the currency of the list                  |
| ValidFrom      | the date at which the list becomes valid  |
| ValidTo        | the last date the list is valid           |
| IsActive       | link to product information web page      |
| IsERPCopy      | whether it's a cache and can't be changed in CRM |

For a complete list of fields, see the [database reference][2].

<!-- Referenced links -->
[1]: https://community.superoffice.com/documentation/SDK/SO.Database/html/Tables-Product.htm
[2]: https://community.superoffice.com/documentation/SDK/SO.Database/html/Tables-PriceList.htm
