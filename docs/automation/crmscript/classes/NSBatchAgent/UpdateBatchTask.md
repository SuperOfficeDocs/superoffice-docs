---
title: crmscript_ref_NSBatchAgent_UpdateBatchTask
description: BatchTaskInfo UpdateBatchTask(BatchTaskInfo batchTaskInfo)
intellisense: NSBatchAgent.UpdateBatchTask
keywords: NSBatchAgent,UpdateBatchTask
so.topic: reference
---

Update information about a BatchTask. Only the following properties can be updated: State, Description, Response and Request.

**Parameters:**
 - **batchTaskInfo** The updated information to save.

**Returns:** The updated BatchTaskInfo

```crmscript
NSBatchAgent agent;
BatchTaskInfo batchTaskInfo;
BatchTaskInfo res = agent.UpdateBatchTask(batchTaskInfo);
```

