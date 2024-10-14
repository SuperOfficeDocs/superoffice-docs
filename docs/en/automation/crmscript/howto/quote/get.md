---
uid: crmscript-quote-get
title: Retrieve quote info
description: How to retrieve quote info with CRMScript, including versions, alternatives, and quote lines.
keywords: CRMScript, quote, sale, QuoteAgent, version
author: Bergfrid Skaara Dias
date: 09.12.2023
version: 10
topic: howto
---

# Retrieve quote info

* To view basic info, use `NSQuote`.
* To view (and possibly update) complex info, use `NSQuoteEntity`.

## NSQuote GetQuote(Integer quoteId)

```crmscript
NSQuoteAgent qa;
NSQuote quote = qa.GetQuote(1);
```

## NSQuote GetQuoteFromSaleId(Integer saleId)

```crmscript
NSQuoteAgent qa;
NSQuote quote = qa.GetQuoteFromSaleId(69);
```

## NSQuoteEntity GetQuoteEntity(Integer quoteId)

```crmscript
NSQuoteAgent qa;
NSQuoteEntity quoteEntity = qa.GetQuoteEntity(1);
```

## NSQuoteEntity GetQuoteEntityFromSaleId(Integer saleId)

A variant of `GetQuoteEntity()` that uses a sale ID to find the quote.

## Get versions

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

<!-- Referenced links -->
