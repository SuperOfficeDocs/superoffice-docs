---
uid: crmscript-product
title: Products
description: Each product belongs to a single price list. How to work with products in CRMScript.
keywords: sale, quote, product, QuoteAgent
author: Bergfrid Skaara Dias
date: 06.12.2023
version: 10
topic: howto
---

# Products

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

<!-- Referenced links -->
[1]: ../../../../database/tables/product.md
