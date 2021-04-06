---
uid: crmscript_ref_NSQuoteVersion_GetStatus
title: QuoteStatus GetStatus()
intellisense: NSQuoteVersion.GetStatus
keywords: NSQuoteVersion, GetStatus
so.topic: reference
---

If there was a problem with for instance calculation, this field is set to warning or error.

**Returns:** QuoteStatus

     - Enum: 0 = Ok 
     - Enum: 1 = OkWithInfo 
     - Enum: 2 = Warning 
     - Enum: 3 = Error 

```crmscript
NSQuoteVersion thing;
QuoteStatus status  = thing.GetStatus();
```


