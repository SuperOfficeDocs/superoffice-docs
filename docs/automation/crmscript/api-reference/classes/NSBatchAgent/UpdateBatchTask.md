---
uid: crmscript_ref_NSBatchAgent_UpdateBatchTask
title: NSBatchTaskInfo UpdateBatchTask(NSBatchTaskInfo batchTaskInfo)
intellisense: NSBatchAgent.UpdateBatchTask
keywords: NSBatchAgent, UpdateBatchTask
so.topic: reference
---

# NSBatchTaskInfo UpdateBatchTask(NSBatchTaskInfo batchTaskInfo)

Update information about a BatchTask. Only the following properties can be updated: State, Description, Response and Request.

**Parameters:**
 - **batchTaskInfo** The updated information to save.

**Returns:** NSBatchTaskInfo

```crmscript
NSBatchAgent agent;
NSBatchTaskInfo batchTaskInfo;
NSBatchTaskInfo res = agent.UpdateBatchTask(batchTaskInfo);
```

