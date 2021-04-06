---
uid: crmscript_ref_NSSystemEventEntity_SetScope
title: SetScope(Integer scope)
intellisense: NSSystemEventEntity.SetScope
keywords: NSSystemEventEntity, GetScope
so.topic: reference
---

1 = system-wide, 2= database, 3 = group, 4 = user

**Parameter:** 
 - **scope** Integer
     - Enum: 0 = Undefined 
     - Enum: 1 = SystemWide 
     - Enum: 2 = Database 
     - Enum: 3 = Group 
     - Enum: 4 = User 

```crmscript
NSSystemEventEntity thing;
Integer scope;
thing.SetScope(scope);
```

