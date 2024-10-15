---
uid: crmscript-quote-create-alternative
title: Create quote alternative
description: How to create a quote alternative with CRMScript.
keywords: CRMScript, quote, QuoteAgent, sale, alternative
author: Bergfrid Skaara Dias
date: 09.12.2023
version: 10
topic: howto
---

# Create alternatives

## NSQuoteAlternative CreateDefaultQuoteAlternative()

Creates an alternative with default values.

```crmscript
NSQuoteAgent qa;
NSQuoteAlternative alt = qa.CreateDefaultQuoteAlternative();
alt.SetName("plan a");
alt.SetQuoteVersionId(1);

// add quote lines

alt = qa.SaveQuoteAlternative(alt);
```

<!-- markdownlint-disable-next-line MD013 -->
## NSQuoteAlternative CreateQuoteAlternative(Integer quoteVersionId, String quoteAlternativeName, String quoteAlternativeDescription)

Creates an alternative for a specific version.

```crmscript
NSQuoteAgent qa;
NSQuoteAlternative alt = qa.CreateQuoteAlternative(1,"plan b","optimized for home office");

// add quote lines

alt = qa.SaveQuoteAlternative(alt);
```

<!-- markdownlint-disable-next-line MD013 -->
## NSQuoteAlternative CopyQuoteAlternative(Integer quoteVersionId, Integer quoteAlternativeId, String quoteAlternativeName)

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

<!-- Referenced links -->
[2]: ../../../../database/tables/quotealternative.md

<!-- Referenced images -->
