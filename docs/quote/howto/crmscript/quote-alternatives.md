---
uid: crmscript_quote_alternatives
title: Alternatives and quote lines
description: Each quote alternative can contain different products, numbers of products, prices, and discounts.
author: Bergfrid Skaara Dias
so.date: 11.02.2021
keywords: CRMScript, quote, quote alternative, quote line
so.topic: howto
---

# Alternatives and quote lines

Each alternative can contain different products, numbers of products, prices, and discounts.

The estimated sales amount for the sale (forecast) is obtained from the total amount for the **favorite alternative**.

* Objects of type `NSQuoteAlternative` belonging to a specific quote [version][1].
* Objects of type `NSQuoteLine` belonging to a specific quote **alternative**.

## Get alternatives

### Get alternatives of a version

```crmscript!
NSQuoteAgent qa;
NSQuoteAlternative[] listOfAlternatives = qa.GetQuoteVersion(8).GetQuoteAlternatives();

for(Integer i = 0; i < listOfAlternatives.length(); i++) {
  printLine(listOfAlternatives[i].GetName() + " |\t" + listOfAlternatives[i].GetStatus().toString());
}
```

### Get a specific alternative

```crmscript!
NSQuoteAgent qa;
NSQuoteAlternative alt = qa.GetQuoteAlternative(6);

printLine(alt.GetTotalPrice().toString(2));
```

### Get favorite alternative

```crmscript!
NSQuoteAgent qa;
NSQuoteVersion version = qa.GetQuoteVersion(1);

Integer fav = version.GetLikelyQuoteAlternativeId();
printLine(fav.toString());

NSQuoteAlternative alt = qa.GetQuoteAlternative(fav);
```

## Create alternatives

### NSQuoteAlternative CreateDefaultQuoteAlternative()

Creates an alternative with default values

```crmscript
NSQuoteAgent qa;
NSQuoteAlternative alt = qa.CreateDefaultQuoteAlternative();
alt.SetName("plan a");
alt.SetQuoteVersionId(1);

// add quote lines

alt = qa.SaveQuoteAlternative(alt);
```

<!-- markdownlint-disable-next-line MD013 -->
### NSQuoteAlternative CreateQuoteAlternative(Integer quoteVersionId, String quoteAlternativeName, String quoteAlternativeDescription)

Creates an alternative for a specific version.

```crmscript
NSQuoteAgent qa;
NSQuoteAlternative alt = qa.CreateQuoteAlternative(1,"plan b","optimized for home office");

// add quote lines

alt = qa.SaveQuoteAlternative(alt);
```

<!-- markdownlint-disable-next-line MD013 -->
### NSQuoteAlternative CopyQuoteAlternative(Integer quoteVersionId, Integer quoteAlternativeId, String quoteAlternativeName)

A variant of `CreateQuoteAlternative()` that clones an alternative into the new one. This is an efficient way of creating multiple alternatives with small variations.

```crmscript
NSQuoteAgent qa;
NSQuoteAlternative alt = qa.CopyQuoteAlternative(1, 2,"plan c");

// modify quote lines

alt = qa.SaveQuoteAlternative(alt);
```

## Set alternatives

```crmscript
NSQuoteAgent qa;

NSQuoteAlternative[] alternatives;

// populate array

NSQuoteVersion version = qa.GetQuoteVersion(1);
version.SetQuoteAlternatives(alternatives);
qa.SaveQuoteVersion(1);
```

## Delete quote alternative

```crmscript
Integer quoteAlternativeId = 13;
NSQuoteAgent qa;
qa.DeleteQuoteAlternative(quoteAlternativeId);
```

## Fetch quote lines

### Get quote lines from alternative

```crmscript!
NSQuoteAgent qa;
Integer quoteAlternativeId = 2;
NSQuoteLine[] lines = qa.GetQuoteLines(quoteAlternativeId);

for(Integer i = 0; i < lines.length(); i++) {
  printLine(lines[i].GetTotalPrice().toString(2) + " , discount= " + lines[i].GetDiscountAmount().toString(2));
}
```

### Get quote line by ID

```crmscript
NSQuoteAgent qa;
NSQuoteLine line = qa.GetQuoteLine(3);

printLine(line.GetUnitCost().toString(2));
```

## Create quote line

Because `CreateQuoteLine()` takes the ID of the quote alternative, it's automatically linked up to an alternative, a version, a quote, and a sale.

You can choose to add a product by its ERP info or as an `NSProduct`.
In either case, you should set the quantity and any discounts for the selected product.

A **discount** can be specified as:

* a percentage rate
* a discount amount
* a total amount

### From product key

```crmscript!
Integer altId = 1;
String erpProductKey = "3412-20";
NSQuoteAgent qa;

NSQuoteLine line = qa.CreateQuoteLine(altId, erpProductKey);

line.SetQuantity(2.0);
line = qa.SaveQuoteLine(line);

printLine(line.GetQuoteLineId().toString());
```

### From NSProduct

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

## NSQuoteLine RecalculateQuoteLine(NSQuoteLine quoteLine, String[] changedFields)

Many numbers in a quote line depend on each other, and changing 1 will affect others. The quote connector recalculates and updates those values so that you don't have to worry about miscalculating. All you have to do is call `RecalculateQuoteLine()` to signal which fields have changed.

For example, if you change the quantity, the total price and VAT amount should change too.

**When to recalculate:**

* Quantity
* DiscountAmount
* DiscountPercent
* ListPrice

When any of these fields are changed, you must recalculate. The format is `TableName.FieldName`.

```crmscript!
NSQuoteAgent qa;
NSQuoteLine line = qa.GetQuoteLine(2);

printLine("Total price before: line.GetTotalPrice().toString(2));

line.SetQuantity(line.GetQuantity()*2);

String[] changedFields;
changedFields.pushBack("QuoteLine.Quantity");

line = qa.RecalculateQuoteLine(line, changedFields);
line = qa.SaveQuoteLine(line);

printLine("Total price after: line.GetTotalPrice().toString(2));
```

This example doubles the existing quantity.

## Void MoveQuoteLine(Integer quoteLineId, Bool direction)

Re-sorts the quote lines of an alternative by moving a specific line up or down.

**Direction:**

* true = move line up
* false = move line down

```crmscript
NSQuoteAgent qa;
qa.MoveQuoteLine(2,true);
```

## Delete quote line

```crmscript
Integer quoteLineId = 7;
NSQuoteAgent qa;
qa.DeleteQuoteLine(quoteLineId);
```

## VAT

The SuperOffice quote connector will calculate the VAT **amount** of an alternative based on the VAT **percent** of the individual lines.

> [!CAUTION]
> Other connectors may implement different VAT algorithms at will! Make sure you interpret the VAT field correctly.

## Reference

### Frequently used QuoteAlternative fields

| Field               | Description                            |
|:--------------------|:---------------------------------------|
| quotealternative_id | ID                                     |
| QuoteVersionId      | the version the alternative belongs to |
| Name                | label for UI                           |
| VAT                 | as calculated amount                   |
| EarningPercent      | in percent of total                    |
| EarningAmount       | as amount                              |
| TotalPrice          | calculated                             |

For a complete list of fields, see the [database reference][2].

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
[1]: quote-properties.md
[2]: ../../../database/tables/quotealternative.md
[3]: ../../../database/tables/quoteline.md
