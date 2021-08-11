---
uid: crmscript_ref_NSQuote_GetUseValuesFromQuote
title: Integer GetUseValuesFromQuote()
intellisense: NSQuote.GetUseValuesFromQuote
keywords: NSQuote, GetUseValuesFromQuote
so.topic: reference
---

# Integer GetUseValuesFromQuote()

If true, then the Earning, Earning_Percent and Amount fields are populated from the QuoteVersion.QuoteAlternative (current revision, most-likely alternative).

**Returns:** Integer

```crmscript
NSQuote thing;
Integer useValuesFromQuote  = thing.GetUseValuesFromQuote();
```

