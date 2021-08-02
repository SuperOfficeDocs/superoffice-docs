---
uid: crmscript_ref_NSBatchAgent_StopBatchJob
title: Bool StopBatchJob(Integer id)
intellisense: NSBatchAgent.StopBatchJob
keywords: NSBatchAgent, StopBatchJob
so.topic: reference
---

Stop a batch job based on Id.

**Parameters:**
 - **id** Id of the batch job to stop.

**Returns:** Bool

```crmscript
NSBatchAgent agent;
Integer id;
Bool res = agent.StopBatchJob(id);
```

