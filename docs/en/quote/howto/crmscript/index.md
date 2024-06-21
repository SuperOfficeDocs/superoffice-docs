---
uid: crmscript-quote
title: Quotes
description: Working with quotes in CRMScript
author: Bergfrid Dias
date: 06.12.2023
keywords: sale, quote
topic: concept
---

# Quotes

For you as a CRMScript developer, working with quotes means that:

* You won't have to worry about miscalculating.
* The sales details can be automatically updated.

## CRMScript classes

There are no native CRMScript classes pertaining to quotes. Use the NetServer classes:

* [NSQuoteAgent][10]
* [NSQuote][11]
* [NSQuoteEntity][12]
* [NSProduct][13]
* [NSPriceList][14]
* [NSQuoteVersion][15]
* [NSQuoteAlternative][16]
* [NSQuoteLine][17]

> [!NOTE]
> Objects of type `NSQuoteAlternative` belonging to a specific quote [version][3].
>
> Objects of type `NSQuoteLine` belonging to a specific quote **alternative**.

## Frequently used fields

| Field | Description |
|:--|:--|
| quote_id | ID |
| SaleId | The corresponding sale |
| QuoteConnectionId | The ERP connection used for this quote |
| ActiveQuoteVersionId | The latest version |
| AcceptedQuoteAlternativeId | The alternative accepted by the customer |
| UseValuesFromQuote | Whether to update the sale (Earning, Earning_Percent and Amount) |
| DocumentId | The quote document |
| PoNumber | The purchase order number |

For a complete list of fields, see the [database reference][7].

## How-tos and examples

* [Create quote][2]
* [Get quote][1]
* [Update quotes and quote versions][3]
* [Various samples][6]

<!-- Referenced links -->
[1]: get.md
[2]: create.md
[3]: update.md
[6]: samples.md
[7]: ../../../database/tables/quote.md
[10]: ../../../automation/crmscript/reference/CRMScript.NetServer.NSQuoteAgent.yml
[11]: ../../../automation/crmscript/reference/CRMScript.NetServer.NSQuote.yml
[12]: ../../../automation/crmscript/reference/CRMScript.NetServer.NSQuoteEntity.yml
[13]: ../../../automation/crmscript/reference/CRMScript.NetServer.NSProduct.yml
[14]: ../../../automation/crmscript/reference/CRMScript.NetServer.NSPriceList.yml
[15]: ../../../automation/crmscript/reference/CRMScript.NetServer.NSQuoteVersion.yml
[16]: ../../../automation/crmscript/reference/CRMScript.NetServer.NSQuoteAlternative.yml
[17]: ../../../automation/crmscript/reference/CRMScript.NetServer.NSQuoteLine.yml

<!-- Referenced images -->
