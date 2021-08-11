---
uid: crmscript_ref_NSSaleSummaryItem_GetCompleted
title: Integer GetCompleted()
intellisense: NSSaleSummaryItem.GetCompleted
keywords: NSSaleSummaryItem, GetCompleted
so.topic: reference
---

# Integer GetCompleted()

The Completed state. NotStarted(1) or Completed(3)

**Returns:** Integer

     - Enum: 0 = Unknown 
     - Enum: 1 = NotStarted 
     - Enum: 2 = Started 
     - Enum: 3 = Completed 

```crmscript
NSSaleSummaryItem thing;
Integer completed  = thing.GetCompleted();
```

