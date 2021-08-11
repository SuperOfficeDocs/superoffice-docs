---
uid: crmscript_ref_NSEMailEntity_SetPriority
title: SetPriority(Integer priority)
intellisense: NSEMailEntity.SetPriority
keywords: NSEMailEntity, GetPriority
so.topic: reference
---

# SetPriority(Integer priority)

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
NSEMailEntity thing;
Integer priority;
thing.SetPriority(priority);
```

