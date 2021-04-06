---
uid: crmscript_ref_NSQuoteEntity_GetUseValuesFromQuote
title: Integer GetUseValuesFromQuote()
intellisense: NSQuoteEntity.GetUseValuesFromQuote
keywords: NSQuoteEntity, GetUseValuesFromQuote
so.topic: reference
---

If true, then the Earning, Earning_Percent and Amount fields are populated from the QuoteVersion.QuoteAlternative (current revision, most-likely alternative).

**Returns:** Integer


```crmscript
NSQuoteEntity thing;
Integer useValuesFromQuote  = thing.GetUseValuesFromQuote();
```


