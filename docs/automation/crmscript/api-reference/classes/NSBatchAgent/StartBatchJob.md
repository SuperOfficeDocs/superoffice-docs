---
uid: crmscript_ref_NSBatchAgent_StartBatchJob
title: Integer StartBatchJob(NSBatchTaskInfo batchTaskInfo)
intellisense: NSBatchAgent.StartBatchJob
keywords: NSBatchAgent, StartBatchJob
so.topic: reference
---

Start a batch job based on NSBatchTaskInfo.

**Parameters:**
 - **batchTaskInfo** Use NSBatchTaskInfo to describe the new batch job.

**Returns:** Integer

```crmscript
NSBatchAgent agent;
NSBatchTaskInfo batchTaskInfo;
Integer res = agent.StartBatchJob(batchTaskInfo);
```

