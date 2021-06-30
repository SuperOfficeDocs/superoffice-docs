---
uid: crmscript_ref_NSBatchAgent_GetBatchTaskInfosByNameAndAssociates
title: BatchTaskInfo[] GetBatchTaskInfosByNameAndAssociates(String name, Integer[] associateIds)
intellisense: NSBatchAgent.GetBatchTaskInfosByNameAndAssociates
keywords: NSBatchAgent, GetBatchTaskInfosByNameAndAssociates
so.topic: reference
---

Get an array of BatchTaskInfo for the provided associate id's and batch task definition name.

**Parameters:**
 - **name** Batchtask definition name.
 - **associateIds** Array of associate id's.

**Returns:** Returns an array of BatchTaskInfo.

```crmscript
NSBatchAgent agent;
String name;
Integer[] associateIds;
BatchTaskInfo[] res = agent.GetBatchTaskInfosByNameAndAssociates(name, associateIds);
```

