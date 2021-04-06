---
uid: crmscript_ref_NSSaleEntity_SetStatus
title: SetStatus(Integer status)
intellisense: NSSaleEntity.SetStatus
keywords: NSSaleEntity, GetStatus
so.topic: reference
---

The state of the Sale: Open / Sold / Lost / Stalled

**Parameter:** 
 - **status** Integer
     - Enum: 0 = Unknown 
     - Enum: 1 = Open 
     - Enum: 2 = Sold 
     - Enum: 3 = Lost 
     - Enum: 4 = Stalled 
     - Enum: 1000 = SaintAll 

```crmscript
NSSaleEntity thing;
Integer status;
thing.SetStatus(status);
```

