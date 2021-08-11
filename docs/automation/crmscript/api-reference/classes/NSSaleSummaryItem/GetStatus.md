---
uid: crmscript_ref_NSSaleSummaryItem_GetStatus
title: Integer GetStatus()
intellisense: NSSaleSummaryItem.GetStatus
keywords: NSSaleSummaryItem, GetStatus
so.topic: reference
---

# Integer GetStatus()

The sale's status, indicating whether the sale is open(1), sold(2) or lost(3).

**Returns:** Integer

     - Enum: 0 = Unknown 
     - Enum: 1 = Open 
     - Enum: 2 = Sold 
     - Enum: 3 = Lost 
     - Enum: 4 = Stalled 
     - Enum: 1000 = SaintAll 

```crmscript
NSSaleSummaryItem thing;
Integer status  = thing.GetStatus();
```

