---
uid: crmscript_ref_NSQuote_SetUseValuesFromQuote
title: SetUseValuesFromQuote(Integer useValuesFromQuote)
intellisense: NSQuote.SetUseValuesFromQuote
keywords: NSQuote, GetUseValuesFromQuote
so.topic: reference
---

# SetUseValuesFromQuote(Integer useValuesFromQuote)

If true, then the Earning, Earning_Percent and Amount fields are populated from the QuoteVersion.QuoteAlternative (current revision, most-likely alternative).

**Parameter:** 
 - **useValuesFromQuote** Integer

```crmscript
NSQuote thing;
Integer useValuesFromQuote;
thing.SetUseValuesFromQuote(useValuesFromQuote);
```

