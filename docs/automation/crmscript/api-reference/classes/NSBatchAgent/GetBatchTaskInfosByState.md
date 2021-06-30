---
uid: crmscript_ref_NSBatchAgent_GetBatchTaskInfosByState
title: BatchTaskInfo[] GetBatchTaskInfosByState(Integer state)
intellisense: NSBatchAgent.GetBatchTaskInfosByState
keywords: NSBatchAgent, GetBatchTaskInfosByState
so.topic: reference
---

Gets an array of BatchTaskInfo with state defined by a BatchTaskState.

**Parameters:**
 - **state** The BatchTaskState to get batch tasks for.
     - Enum: 0 = Unknown 
     - Enum: 1 = New 
     - Enum: 2 = Aquired 
     - Enum: 3 = Started 
     - Enum: 4 = Succeeded 
     - Enum: 5 = Failed 
     - Enum: 6 = SucceededManualCleanup 
     - Enum: 99999 = All 

**Returns:** Returns an array of BatchTaskInfo.

```crmscript
NSBatchAgent agent;
Integer state;
BatchTaskInfo[] res = agent.GetBatchTaskInfosByState(state);
```

