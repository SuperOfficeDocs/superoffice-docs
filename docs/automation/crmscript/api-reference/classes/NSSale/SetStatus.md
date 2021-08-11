---
uid: crmscript_ref_NSSale_SetStatus
title: SetStatus(Integer status)
intellisense: NSSale.SetStatus
keywords: NSSale, GetStatus
so.topic: reference
---

# SetStatus(Integer status)

The sale's status, indicating wether the sale is open, sold or lost.

**Parameter:** 
 - **status** Integer
     - Enum: 0 = Unknown 
     - Enum: 1 = Open 
     - Enum: 2 = Sold 
     - Enum: 3 = Lost 
     - Enum: 4 = Stalled 
     - Enum: 1000 = SaintAll 

```crmscript
NSSale thing;
Integer status;
thing.SetStatus(status);
```

