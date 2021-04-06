---
uid: crmscript_ref_NSEMailEnvelope_SetPriority
title: SetPriority(Integer priority)
intellisense: NSEMailEnvelope.SetPriority
keywords: NSEMailEnvelope, GetPriority
so.topic: reference
---

Importance of the e-mail

**Parameter:** 
 - **priority** Integer
     - Enum: 0 = NoPriority 
     - Enum: 1 = Highest 
     - Enum: 2 = High 
     - Enum: 3 = Normal 
     - Enum: 4 = Low 
     - Enum: 5 = Lowest 

```crmscript
NSEMailEnvelope thing;
Integer priority;
thing.SetPriority(priority);
```

