---
uid: crmscript_ref_NSQuoteVersionStatusInformation_SetStatus
title: SetStatus(Integer status)
intellisense: NSQuoteVersionStatusInformation.SetStatus
keywords: NSQuoteVersionStatusInformation, GetStatus
so.topic: reference
---

# SetStatus(Integer status)

Status information for the quote version.

**Parameter:** 
 - **status** Integer
     - Enum: 0 = Ok 
     - Enum: 1 = OkWithInfo 
     - Enum: 2 = Warning 
     - Enum: 3 = Error 

```crmscript
NSQuoteVersionStatusInformation thing;
Integer status;
thing.SetStatus(status);
```

