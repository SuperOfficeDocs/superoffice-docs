---
uid: crmscript-quote-samples
title: Quotes
description: Working with quotes in CRMScript
keywords: sale, quote, quoteconnection
author: Bergfrid Dias
date: 06.12.2023
version: 10
topic: howto
---

# Samples

## Find available quote connections

```crmscript!
SearchEngine se;
se.addFields("QuoteConnection", "quoteconnection_id,DisplayName,Rank");
print(se.executeTextTable());
```

## Find the latest version

```crmscript!
NSQuoteAgent qa;
NSQuote quote = qa.GetQuote(2);
Integer versionNumber = quote.GetActiveQuoteVersionId();

printLine("Active version: " + versionNumber.toString());
```

## Order-related info you might want to check

### Accepted quote alternative

```crmscript!
NSQuoteAgent qa;
NSQuoteEntity quote = qa.GetQuoteEntity(11);
printLine(quote.GetAcceptedQuoteAlternativeId().toString());
```

### PO number

```crmscript!
NSQuoteAgent qa;
NSQuoteEntity quote = qa.GetQuoteEntity(11);
printLine(quote.GetPoNumber());
```

### Accepted by customer?

```crmscript!
NSQuoteAgent qa;
NSQuoteEntity quote = qa.GetQuoteEntity(11);
NSQuoteVersion version = qa.GetQuoteVersion(quote.GetActiveQuoteVersionId());
Integer state = version.GetState();

if (state == 9) {
  printLine("Accepted by customer");
}
else if (state == 8) {
  printLine("Rejected by customer");
}
else {
  printLine("quote not finalized yet");
}
```

## Mark sale as sold

```crmscript
NSQuoteAgent qa;
NSQuoteEntity quote = qa.GetQuoteEntity(11);

NSSaleEntity sale = saleAgent.GetSaleEntity(quote.GetSaleId());
sale.SetStatus(2);
sale = saleAgent.SaveSaleEntity(sale);
```
