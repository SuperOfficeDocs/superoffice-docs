---
uid: crmscript_ref_NSSystemEventEntity_GetScope
title: Integer GetScope()
intellisense: NSSystemEventEntity.GetScope
keywords: NSSystemEventEntity, GetScope
so.topic: reference
---

1 = system-wide, 2= database, 3 = group, 4 = user

**Returns:** Integer

     - Enum: 0 = Undefined 
     - Enum: 1 = SystemWide 
     - Enum: 2 = Database 
     - Enum: 3 = Group 
     - Enum: 4 = User 

```crmscript
NSSystemEventEntity thing;
Integer scope  = thing.GetScope();
```


