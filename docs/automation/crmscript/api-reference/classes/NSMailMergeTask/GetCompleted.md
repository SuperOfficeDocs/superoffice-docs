---
uid: crmscript_ref_NSMailMergeTask_GetCompleted
title: Integer GetCompleted()
intellisense: NSMailMergeTask.GetCompleted
keywords: NSMailMergeTask, GetCompleted
so.topic: reference
---

Completed status for task

**Returns:** Integer

     - Enum: 0 = Unknown 
     - Enum: 1 = NotStarted 
     - Enum: 2 = Started 
     - Enum: 3 = Completed 

```crmscript
NSMailMergeTask thing;
Integer completed  = thing.GetCompleted();
```


