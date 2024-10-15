---
uid: crmscript-quote-update
title: Update quote
description: How to update or delete a quote with CRMScript
keywords: CRMScript, quotes
author: Bergfrid Skaara Dias
date: 09.12.2023
version: 10
topic: howto
---

# Update quote

Updates to a quote mostly target the [alternatives][4] and [quote lines][3]. You will, however, see some changes to the quote properties when dealing with [quote documents][5] and [placing orders][6].

When updating quotes, you'll always be working on the latest version.

## Update version

This example extends the expiration date by 1 week:

```crmscript
NSQuoteAgent qa;
NSQuoteVersion version = qa.GetQuoteVersion(3);

version.SetExpirationDate(version.GetExpirationDate().addDays(7));

version = qa.SaveQuoteVersion(version);

printLine("New expiration date: " + version.GetExpirationDate().toString());
```

> [!TIP]
> Remember to call `SaveQuoteVersion()` whenever you update a version!

## NSQuoteVersion CreateAndSaveQuoteVersion(Integer quoteVersionId)

Creates a new version based on another version of the same quote. This is your only option when you want to edit a sent quote.

```crmscript
NSQuoteAgent qa;
NSQuoteVersion version = qa.CreateAndSaveQuoteVersion(2);
```

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

## Delete quote alternative

```crmscript
Integer quoteAlternativeId = 13;
NSQuoteAgent qa;
qa.DeleteQuoteAlternative(quoteAlternativeId);
```

## Delete quote

> [!CAUTION]
> Always check before deleting. There might be legal and/or financial reasons to keep quote info in the system.

```crmscript
Integer quoteId = 13;
NSQuoteAgent qa;
qa.DeleteQuote(quoteId);
```

## References

### Frequently used QuoteVersion fields

| Field | Description |
|:--|:--|
| quoteversion_id | ID |
| QuoteId | Parent quote |
| State | |
| LikelyQuoteAlternativeId | Alt. most likely to be accepted<br>used to calculate probable income |
| SentDate | When the version was sent to the customer |
| FollowupId | The follow-up created when the version was sent |
| ExpirationDate | The last date on which the offer is valid |
| Rank | The version number |

For a complete list of fields, see the [database reference][8].

<!-- Referenced links -->
[3]: add-quote-line.md
[4]: add-alternative.md
[5]: quote-document.md
[6]: place-order.md
[8]: ../../../../database/tables/quoteversion.md
