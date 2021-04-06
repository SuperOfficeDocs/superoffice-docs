---
uid: crmscript_quote_properties
title: One quote per sale
author:
so.date:
keywords:
so.topic:
---

# One quote per sale

Quotes are what connects products to a sale. You must [record a sale][1] **before** you can add a quote. Also, [products][2] must have been registered before you can add them to a quote.

> [!NOTE]
> Each quote belongs to a single sale. And there's only 1 quote per sale.

## Retrieve quote info

* To view basic info, use `NSQuote`.
* To view (and possibly update) complex info, use `NSQuoteEntity`.

### NSQuote GetQuote(Integer quoteId)

```crmscript
NSQuoteAgent qa;
NSQuote quote = qa.GetQuote(1);
```

### NSQuote GetQuoteFromSaleId(Integer saleId)

```crmscript
NSQuoteAgent qa;
NSQuote quote = qa.GetQuoteFromSaleId(69);
```

### NSQuoteEntity GetQuoteEntity(Integer quoteId)

```crmscript
NSQuoteAgent qa;
NSQuoteEntity quoteEntity = qa.GetQuoteEntity(1);
```

### NSQuoteEntity GetQuoteEntityFromSaleId(Integer saleId)

A variant of `GetQuoteEntity()` that uses a sale ID to find the quote.

## Create quote

You can either create a quote **from scratch or copy** an existing quote from another sale.

### NSQuoteEntity CreateAndSaveQuote(Integer saleId, Integer connectionId, String firstAlternativeName)

```crmscript!
NSQuoteAgent qa;
NSQuoteEntity quote = qa.CreateAndSaveQuote(72,1,"basic gardening supplies");

printLine(quote.GetQuoteId().toString());
```

> [!TIP]
> If there's no external ERP connection, you're most likely using SuperOffice with ID 1.

### NSQuoteEntity CreateAndSaveQuoteFromSale(Integer copyFromSaleId, Integer copyToSaleId)

 The quote is copied with its products and alternatives.

```crmscript!
NSQuoteAgent qa;
NSQuoteEntity quote = qa.CreateAndSaveQuoteFromSale(67,73);

printLine(quote.GetSaleId().toString());
```

> [!NOTE]
> The sale you copy the quote **from** must have the same [currency][3] as the sale you are copying it **to**.

## Update quote

Updates to a quote mostly target the [alternatives and quote lines][4]. You will, however, see some changes to the quote properties when dealing with [quote documents][5] and [placing orders][6].

## Versions

There may be multiple versions of a quote, but only 1 of them is **active** at any time.
Each version will have 1 or more [alternatives][4], which in turn will have 1 or more quote lines.

When updating quotes, you'll always be working on the latest version.

### Find the latest version

```crmscript!
NSQuoteAgent qa;
NSQuote quote = qa.GetQuote(2);
Integer versionNumber = quote.GetActiveQuoteVersionId();

printLine("Active version: " + versionNumber.toString());
```

### NSQuoteVersion GetQuoteVersion(Integer quoteVersionId)

Fetches a specific version.

```crmscript!
NSQuoteAgent qa;
NSQuoteVersion version = qa.GetQuoteVersion(3);

printLine(version.GetExpirationDate().toString());
```

### NSQuoteVersion[] GetQuoteVersions(Integer quoteId)

Fetches all quote versions for a sale.

```crmscript!
NSQuoteAgent qa;
NSQuoteVersion[] versionList = qa.GetQuoteVersions(5);

for(Integer i = 0; i < versionList.length(); i++) {
  printLine(versionList[i].GetRank().toString() + " |\t" + versionList[i].GetState().toString());
}
```

### NSQuoteVersion CreateAndSaveQuoteVersion(Integer quoteVersionId)

Creates a new version based on another version of the same quote. This is your only option when you want to edit a sent quote.

```crmscript
NSQuoteAgent qa;
NSQuoteVersion version = qa.CreateAndSaveQuoteVersion(2);
```

### Update version

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

## Delete quote

> [!CAUTION]
> Always check before deleting. There might be legal and/or financial reasons to keep quote info in the system.

```crmscript
Integer quoteId = 13;
NSQuoteAgent qa;
qa.DeleteQuote(quoteId);
```

## References

### Frequently used Quote fields

| Field                | Description                               |
|:---------------------|:------------------------------------------|
| quote_id             | ID                                        |
| SaleId               | the corresponding sale                    |
| QuoteConnectionId    | the ERP connection used for this quote    |
| ActiveQuoteVersionId | the latest version                        |
| AcceptedQuoteAlternativeId | the alternative accepted by the customer |
| UseValuesFromQuote   | whether to update the sale (Earning, Earning_Percent and Amount) |
| DocumentId           | the quote document                        |
| PoNumber             | the purchase order number                 |

For a complete list of fields, see the [database reference][7].

### Frequently used QuoteVersion fields

| Field                | Description                               |
|:---------------------|:------------------------------------------|
| quoteversion_id      | ID                                        |
| QuoteId              | parent quote                              |
| State                |                                           |
| LikelyQuoteAlternativeId | alt. most likely to be accepted<br>used to calculate probable income |
| SentDate             | when the version was sent to the customer |
| FollowupId           | the follow-up created when version was sent |
| ExpirationDate       | the last date on which the offer is valid |
| Rank                 | the version number                        |

For a complete list of fields, see the [database reference][8].

### State

| State | Description                               |
|:-----:|:------------------------------------------|
| 0     | unknown                                   |
| 1     | OK: draft calculated and verified by ERP  |
| 2     | draft not calculated: prices and other attributes may not be valid |
| 3     | draft has problems requiring approval     |
| 4     | draft approved (with problems)            |
| 5     | draft not approved due to problems        |
| 6     | sent to customer and is now a legally binding document |
| 7     | archived                                  |
| 8     | rejected by customer (sale lost)          |
| 9     | accepted by customer (sold)               |

### Status

| Status | Description                               |
|:------:|:------------------------------------------|
| 0      | OK, all is good                           |
| 1      | All is good, however the user should be made aware of something |
| 2      | problem - notify user                     |
| 3      | problem - action required                 |

<!-- Referenced links -->
[1]: ../sales/leads.md
[2]: products.md
[3]: index.md
[4]: quote-alternatives.md
[5]: quote-document.md
[6]: quote-order.md
[7]: https://community.superoffice.com/documentation/SDK/SO.Database/html/Tables-Quote.htm
[8]: https://community.superoffice.com/documentation/SDK/SO.Database/html/Tables-QuoteVersion.htm
