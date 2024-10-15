---
uid: crmscript-quote-add-line
title: Add quote line
description: How to create a quote line with CRMScript.
keywords: CRMScript, quote, quote alternative, quote line, product
author: Bergfrid Skaara Dias
date: 06.12.2023
version: 10
topic: howto
---

# Add quote line

Because `CreateQuoteLine()` takes the ID of the quote alternative, it's automatically linked up to an alternative, a version, a quote, and a sale.

You can choose to add a product by its ERP info or as an `NSProduct`. In either case, you should set the quantity and any discounts for the selected product.

## Create from product key

```crmscript!
Integer altId = 1;
String erpProductKey = "3412-20";
NSQuoteAgent qa;

NSQuoteLine line = qa.CreateQuoteLine(altId, erpProductKey);

line.SetQuantity(2.0);
line = qa.SaveQuoteLine(line);

printLine(line.GetQuoteLineId().toString());
```

## Create from NSProduct

```crmscript!
Integer altId = 2;
NSQuoteAgent qa;
NSProduct product = qa.GetProduct(1,"3412-20");

NSQuoteLine line = qa.CreateQuoteLineFromProduct(altId, product);
line.SetQuantity(10.0);
line = qa.SaveQuoteLine(line);

printLine(line.GetQuoteLineId().toString());
```

> [!TIP]
> Remember to call `SaveQuoteLine()` when you're done building the line!

## Reference

### Frequently used QuoteLine fields

| Field              | Description                          |
|:-------------------|:-------------------------------------|
| quoteline_id       | ID                                   |
| QuoteAlternativeId | the alternative this line belongs to |
| Name               | product name                         |
| Code               | the product code or article number   |
| Rank               | for sorting                          |

The line will also include **information duplicated from the product** (rather than referenced).

For a complete list of fields, see the [database reference][3].

<!-- Referenced links -->
[3]: ../../../../database/tables/quoteline.md
