---
uid: crmscript_ref_NSBatchAgent_GetBatchTaskInfosByNameAndAssociates
title: NSBatchTaskInfo[] GetBatchTaskInfosByNameAndAssociates(String name, Integer[] associateIds)
intellisense: NSBatchAgent.GetBatchTaskInfosByNameAndAssociates
keywords: NSBatchAgent, GetBatchTaskInfosByNameAndAssociates
so.topic: reference
---

# NSBatchTaskInfo[] GetBatchTaskInfosByNameAndAssociates(String name, Integer[] associateIds)

Get an array of NSBatchTaskInfo for the provided associate id's and batch task definition name.

**Parameters:**
 - **name** Batchtask definition name.
 - **associateIds** Array of associate id's.

**Returns:** NSBatchTaskInfo[]

```crmscript
NSBatchAgent agent;
String name;
Integer[] associateIds;
NSBatchTaskInfo[] res = agent.GetBatchTaskInfosByNameAndAssociates(name, associateIds);
```

