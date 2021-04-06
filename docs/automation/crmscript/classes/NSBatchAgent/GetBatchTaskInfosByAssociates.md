---
uid: crmscript_ref_NSBatchAgent_GetBatchTaskInfosByAssociates
title: BatchTaskInfoArray GetBatchTaskInfosByAssociates(IntegerArray associateIds)
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
IntegerArray associateIds;
BatchTaskInfoArray res = agent.GetBatchTaskInfosByAssociates(associateIds);
```

