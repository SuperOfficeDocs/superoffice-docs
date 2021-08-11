---
uid: crmscript_ref_NSSale_GetStatus
title: Integer GetStatus()
intellisense: NSSale.GetStatus
keywords: NSSale, GetStatus
so.topic: reference
---

# Integer GetStatus()

The sale's status, indicating wether the sale is open, sold or lost.

**Returns:** Integer

     - Enum: 0 = Unknown 
     - Enum: 1 = Open 
     - Enum: 2 = Sold 
     - Enum: 3 = Lost 
     - Enum: 4 = Stalled 
     - Enum: 1000 = SaintAll 

```crmscript
NSSale thing;
Integer status  = thing.GetStatus();
```

