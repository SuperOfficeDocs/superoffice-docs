---
uid: crmscript_ref_NSEMailEntity_GetPriority
title: Integer GetPriority()
intellisense: NSEMailEntity.GetPriority
keywords: NSEMailEntity, GetPriority
so.topic: reference
---

# Integer GetPriority()

Importance of the e-mail

**Returns:** Integer

     - Enum: 0 = NoPriority 
     - Enum: 1 = Highest 
     - Enum: 2 = High 
     - Enum: 3 = Normal 
     - Enum: 4 = Low 
     - Enum: 5 = Lowest 

```crmscript
NSEMailEntity thing;
Integer priority  = thing.GetPriority();
```

