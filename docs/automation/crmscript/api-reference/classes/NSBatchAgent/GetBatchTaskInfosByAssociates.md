---
uid: crmscript_ref_NSBatchAgent_GetBatchTaskInfosByAssociates
title: NSBatchTaskInfo[] GetBatchTaskInfosByAssociates(Integer[] associateIds)
intellisense: NSBatchAgent.GetBatchTaskInfosByAssociates
keywords: NSBatchAgent, GetBatchTaskInfosByAssociates
so.topic: reference
---

Get an array of NSBatchTaskInfo for the provided associate id's.

**Parameters:**
 - **associateIds** Array of associate id's.

**Returns:** NSBatchTaskInfo[]

```crmscript
NSBatchAgent agent;
Integer[] associateIds;
NSBatchTaskInfo[] res = agent.GetBatchTaskInfosByAssociates(associateIds);
```

