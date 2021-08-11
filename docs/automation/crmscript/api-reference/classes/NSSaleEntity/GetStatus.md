---
uid: crmscript_ref_NSSaleEntity_GetStatus
title: Integer GetStatus()
intellisense: NSSaleEntity.GetStatus
keywords: NSSaleEntity, GetStatus
so.topic: reference
---

# Integer GetStatus()

The state of the Sale: Open / Sold / Lost / Stalled

**Returns:** Integer

     - Enum: 0 = Unknown 
     - Enum: 1 = Open 
     - Enum: 2 = Sold 
     - Enum: 3 = Lost 
     - Enum: 4 = Stalled 
     - Enum: 1000 = SaintAll 

```crmscript
NSSaleEntity thing;
Integer status  = thing.GetStatus();
```

