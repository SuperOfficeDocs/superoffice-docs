---
uid: crmscript_ref_NSQuoteEntity_SetUseValuesFromQuote
title: SetUseValuesFromQuote(Integer useValuesFromQuote)
intellisense: NSQuoteEntity.SetUseValuesFromQuote
keywords: NSQuoteEntity, GetUseValuesFromQuote
so.topic: reference
---

# SetUseValuesFromQuote(Integer useValuesFromQuote)

If true, then the Earning, Earning_Percent and Amount fields are populated from the QuoteVersion.QuoteAlternative (current revision, most-likely alternative).

**Parameter:** 
 - **useValuesFromQuote** Integer

```crmscript
NSQuoteEntity thing;
Integer useValuesFromQuote;
thing.SetUseValuesFromQuote(useValuesFromQuote);
```

