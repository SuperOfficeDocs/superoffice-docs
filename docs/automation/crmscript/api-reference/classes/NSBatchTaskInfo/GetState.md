---
uid: crmscript_ref_NSBatchTaskInfo_GetState
title: Integer GetState()
intellisense: NSBatchTaskInfo.GetState
keywords: NSBatchTaskInfo, GetState
so.topic: reference
---

# Integer GetState()

BatchTaskState of the task.

**Returns:** Integer

     - Enum: 0 = Unknown 
     - Enum: 1 = New 
     - Enum: 2 = Aquired 
     - Enum: 3 = Started 
     - Enum: 4 = Succeeded 
     - Enum: 5 = Failed 
     - Enum: 6 = SucceededManualCleanup 
     - Enum: 99999 = All 

```crmscript
NSBatchTaskInfo thing;
Integer state  = thing.GetState();
```

