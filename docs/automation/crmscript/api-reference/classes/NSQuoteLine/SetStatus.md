---
uid: crmscript_ref_NSQuoteLine_SetStatus
title: SetStatus(Integer status)
intellisense: NSQuoteLine.SetStatus
keywords: NSQuoteLine, GetStatus
so.topic: reference
---

# SetStatus(Integer status)

If there was a problem with for instance calculation, this field is set to warning or error. Typically shown as an icon. Integer is an enum with statuses: OK, OKWithInfo, Warning, Error.

**Parameter:** 
 - **status** Integer
     - Enum: 0 = Ok 
     - Enum: 1 = OkWithInfo 
     - Enum: 2 = Warning 
     - Enum: 3 = Error 

```crmscript
NSQuoteLine thing;
Integer status;
thing.SetStatus(status);
```

