---
uid: crmscript_ref_NSQuoteAlternative_SetStatus
title: SetStatus(Integer status)
intellisense: NSQuoteAlternative.SetStatus
keywords: NSQuoteAlternative, GetStatus
so.topic: reference
---

# SetStatus(Integer status)

If there was a problem with for instance calculation, this field is set to warning or error.

**Parameter:** 
 - **status** Integer
     - Enum: 0 = Ok 
     - Enum: 1 = OkWithInfo 
     - Enum: 2 = Warning 
     - Enum: 3 = Error 

```crmscript
NSQuoteAlternative thing;
Integer status;
thing.SetStatus(status);
```

