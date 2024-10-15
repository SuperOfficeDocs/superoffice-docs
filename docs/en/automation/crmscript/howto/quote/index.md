---
uid: crmscript-quote
title: Quotes
description: Working with quotes in CRMScript
keywords: sale, quote
author: Bergfrid Dias
date: 06.12.2023
version: 10
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

For a complete list of fields, see the [database reference][20].

## How-tos and examples

* [Create quote][2]
* [Get quote][1]
* [Update quotes and quote versions][3]
* [Quote alternatives and quote lines][7]
* [Products and price lists][8]
* [Quote document][4]
* [Place order][5]
* [Various samples][6]

<!-- Referenced links -->
[1]: get.md
[2]: create.md
[3]: update.md
[4]: quote-document.md
[5]: place-order.md
[6]: samples.md
[7]: add-alternative.md
[8]: products.md
[10]: ../../reference/CRMScript.NetServer.NSQuoteAgent.yml
[11]: ../../reference/CRMScript.NetServer.NSQuote.yml
[12]: ../../reference/CRMScript.NetServer.NSQuoteEntity.yml
[13]: ../../reference/CRMScript.NetServer.NSProduct.yml
[14]: ../../reference/CRMScript.NetServer.NSPriceList.yml
[15]: ../../reference/CRMScript.NetServer.NSQuoteVersion.yml
[16]: ../../reference/CRMScript.NetServer.NSQuoteAlternative.yml
[17]: ../../reference/CRMScript.NetServer.NSQuoteLine.yml
[20]: ../../../../database/tables/quote.md

<!-- Referenced images -->
