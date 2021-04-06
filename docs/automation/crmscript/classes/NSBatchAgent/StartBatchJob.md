---
uid: crmscript_ref_NSBatchAgent_StartBatchJob
title: Integer StartBatchJob(BatchTaskInfo batchTaskInfo)
intellisense: NSBatchAgent.StartBatchJob
keywords: NSBatchAgent, StartBatchJob
so.topic: reference
---

Start a batch job based on BatchTaskInfo.

**Parameters:**
 - **batchTaskInfo** Use BatchTaskInfo to describe the new batch job.

**Returns:** Returns the id of the created batch job.

```crmscript
NSBatchAgent agent;
BatchTaskInfo batchTaskInfo;
Integer res = agent.StartBatchJob(batchTaskInfo);
```

