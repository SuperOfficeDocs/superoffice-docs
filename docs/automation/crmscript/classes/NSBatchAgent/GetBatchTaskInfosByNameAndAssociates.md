---
title: crmscript_ref_NSBatchAgent_GetBatchTaskInfosByNameAndAssociates
description: BatchTaskInfoArray GetBatchTaskInfosByNameAndAssociates(String name, IntegerArray associateIds)
intellisense: NSBatchAgent.GetBatchTaskInfosByNameAndAssociates
keywords: NSBatchAgent,GetBatchTaskInfosByNameAndAssociates
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
IntegerArray associateIds;
BatchTaskInfoArray res = agent.GetBatchTaskInfosByNameAndAssociates(name, associateIds);
```

