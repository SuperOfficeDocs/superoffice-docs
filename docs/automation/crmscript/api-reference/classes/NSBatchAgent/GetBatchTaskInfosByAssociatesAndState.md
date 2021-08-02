---
uid: crmscript_ref_NSBatchAgent_GetBatchTaskInfosByAssociatesAndState
title: NSBatchTaskInfo[] GetBatchTaskInfosByAssociatesAndState(Integer[] associateIds, Integer state)
intellisense: NSBatchAgent.GetBatchTaskInfosByAssociatesAndState
keywords: NSBatchAgent, GetBatchTaskInfosByAssociatesAndState
so.topic: reference
---

Get an array of NSBatchTaskInfo for the provided associate id's and batch task state.

**Parameters:**
 - **associateIds** Array of associate id's.
 - **state** The BatchTaskState to get batch tasks for.
     - Enum: 0 = Unknown 
     - Enum: 1 = New 
     - Enum: 2 = Aquired 
     - Enum: 3 = Started 
     - Enum: 4 = Succeeded 
     - Enum: 5 = Failed 
     - Enum: 6 = SucceededManualCleanup 
     - Enum: 99999 = All 

**Returns:** NSBatchTaskInfo[]

```crmscript
NSBatchAgent agent;
Integer[] associateIds;
Integer state;
NSBatchTaskInfo[] res = agent.GetBatchTaskInfosByAssociatesAndState(associateIds, state);
```

