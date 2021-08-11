---
uid: crmscript_ref_NSBatchTaskInfo_SetIsInternalTask
title: SetIsInternalTask(Bool isInternalTask)
intellisense: NSBatchTaskInfo.SetIsInternalTask
keywords: NSBatchTaskInfo, GetIsInternalTask
so.topic: reference
---

# SetIsInternalTask(Bool isInternalTask)

If IsInternalTask is true, this task will not add a trace to the database.

**Parameter:** 
 - **isInternalTask** Bool

```crmscript
NSBatchTaskInfo thing;
Bool isInternalTask;
thing.SetIsInternalTask(isInternalTask);
```

