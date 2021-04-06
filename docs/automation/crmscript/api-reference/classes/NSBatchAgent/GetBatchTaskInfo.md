---
uid: crmscript_ref_NSBatchAgent_GetBatchTaskInfo
title: BatchTaskInfo GetBatchTaskInfo(Integer id)
intellisense: NSBatchAgent.GetBatchTaskInfo
keywords: NSBatchAgent, GetBatchTaskInfo
so.topic: reference
---

Get a single BatchTaskInfo based on Id.

**Parameters:**
 - **id** Id of the BatchTaskInfo to get.

**Returns:** Returns a BatchTaskInfo.

```crmscript
NSBatchAgent agent;
Integer id;
BatchTaskInfo res = agent.GetBatchTaskInfo(id);
```

