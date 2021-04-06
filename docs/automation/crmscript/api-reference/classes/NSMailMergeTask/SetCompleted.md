---
uid: crmscript_ref_NSMailMergeTask_SetCompleted
title: SetCompleted(Integer completed)
intellisense: NSMailMergeTask.SetCompleted
keywords: NSMailMergeTask, GetCompleted
so.topic: reference
---

Completed status for task

**Parameter:** 
 - **completed** Integer
     - Enum: 0 = Unknown 
     - Enum: 1 = NotStarted 
     - Enum: 2 = Started 
     - Enum: 3 = Completed 

```crmscript
NSMailMergeTask thing;
Integer completed;
thing.SetCompleted(completed);
```

