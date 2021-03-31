---
title: crmscript_ref_NSBatchAgent_StopBatchJob
description: Bool StopBatchJob(Integer id)
intellisense: NSBatchAgent.StopBatchJob
keywords: NSBatchAgent,StopBatchJob
so.topic: reference
---

Stop a batch job based on Id.

**Parameters:**
 - **id** Id of the batch job to stop.

**Returns:** Returns true if the job was stopped successfully.

```crmscript
NSBatchAgent agent;
Integer id;
Bool res = agent.StopBatchJob(id);
```

