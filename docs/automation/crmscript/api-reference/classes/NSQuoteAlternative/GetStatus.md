---
uid: crmscript_ref_NSQuoteAlternative_GetStatus
title: Integer GetStatus()
intellisense: NSQuoteAlternative.GetStatus
keywords: NSQuoteAlternative, GetStatus
so.topic: reference
---

# Integer GetStatus()

If there was a problem with for instance calculation, this field is set to warning or error.

**Returns:** Integer

     - Enum: 0 = Ok 
     - Enum: 1 = OkWithInfo 
     - Enum: 2 = Warning 
     - Enum: 3 = Error 

```crmscript
NSQuoteAlternative thing;
Integer status  = thing.GetStatus();
```

