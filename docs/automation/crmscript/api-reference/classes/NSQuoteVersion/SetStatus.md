---
uid: crmscript_ref_NSQuoteVersion_SetStatus
title: SetStatus(Integer status)
intellisense: NSQuoteVersion.SetStatus
keywords: NSQuoteVersion, GetStatus
so.topic: reference
---

If there was a problem with for instance calculation, this field is set to warning or error.

**Parameter:** 
 - **status** Integer
     - Enum: 0 = Ok 
     - Enum: 1 = OkWithInfo 
     - Enum: 2 = Warning 
     - Enum: 3 = Error 

```crmscript
NSQuoteVersion thing;
Integer status;
thing.SetStatus(status);
```

