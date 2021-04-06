---
uid: crmscript_ref_NSSaleSummaryItem_SetCompleted
title: SetCompleted(Integer completed)
intellisense: NSSaleSummaryItem.SetCompleted
keywords: NSSaleSummaryItem, GetCompleted
so.topic: reference
---

The Completed state. NotStarted(1) or Completed(3)

**Parameter:** 
 - **completed** Integer
     - Enum: 0 = Unknown 
     - Enum: 1 = NotStarted 
     - Enum: 2 = Started 
     - Enum: 3 = Completed 

```crmscript
NSSaleSummaryItem thing;
Integer completed;
thing.SetCompleted(completed);
```

