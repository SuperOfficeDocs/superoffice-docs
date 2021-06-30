---
uid: crmscript_ref_NSBatchAgent_GetBatchTaskInfosByAssociates
title: BatchTaskInfo[] GetBatchTaskInfosByAssociates(Integer[] associateIds)
intellisense: NSBatchAgent.GetBatchTaskInfosByAssociates
keywords: NSBatchAgent, GetBatchTaskInfosByAssociates
so.topic: reference
---

Get an array of BatchTaskInfo for the provided associate id's.

**Parameters:**
 - **associateIds** Array of associate id's.

**Returns:** Returns an array of BatchTaskInfo.

```crmscript
NSBatchAgent agent;
Integer[] associateIds;
BatchTaskInfo[] res = agent.GetBatchTaskInfosByAssociates(associateIds);
```

