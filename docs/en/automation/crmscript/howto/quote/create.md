---
uid: crmscript-quote-create
title: Create quote
description: How to create a quote with CRMScript.
keywords: CRMScript, quote, QuoteAgent, sale, alternative
author: Bergfrid Skaara Dias
date: 09.12.2023
version: 10
topic: howto
---

# Create quote

You can either create a quote **from scratch or copy** an existing quote from another sale.

<!-- markdownlint-disable-next-line MD013 -->
## NSQuoteEntity CreateAndSaveQuote(Integer saleId, Integer connectionId, String firstAlternativeName)

```crmscript!
NSQuoteAgent qa;
NSQuoteEntity quote = qa.CreateAndSaveQuote(72,1,"basic gardening supplies");

printLine(quote.GetQuoteId().toString());
```

> [!TIP]
> If there's no external ERP connection, you're most likely using SuperOffice with ID 1.

## NSQuoteEntity CreateAndSaveQuoteFromSale(Integer copyFromSaleId, Integer copyToSaleId)

 The quote is copied with its products and alternatives.

```crmscript!
NSQuoteAgent qa;
NSQuoteEntity quote = qa.CreateAndSaveQuoteFromSale(67,73);

printLine(quote.GetSaleId().toString());
```

> [!NOTE]
> The sale you copy the quote **from** must have the same [currency][3] as the sale you are copying it **to**.

## Next

* [Create alternatives][1]
* [Add quote lines][2]

<!-- Referenced links -->
[1]: add-alternative.md
[2]: add-quote-line.md
[3]: ../../../../sale/overview.md#currency
