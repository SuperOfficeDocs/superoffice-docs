---
uid: crmscript_ref_NSQuoteAlternative_GetQuoteVersionId
title: Integer GetQuoteVersionId()
intellisense: NSQuoteAlternative.GetQuoteVersionId
keywords: NSQuoteAlternative, GetQuoteVersionId
so.topic: reference
---

The version that owns this alternative (the chain is Sale 1->1 Quote 1->+ QuoteVersion 1->+ QuoteAlternative.

**Returns:** Integer


```crmscript
NSQuoteAlternative thing;
Integer quoteVersionId  = thing.GetQuoteVersionId();
```


