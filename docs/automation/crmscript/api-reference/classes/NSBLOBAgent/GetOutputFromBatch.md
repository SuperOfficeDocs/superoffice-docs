---
uid: crmscript_ref_NSBLOBAgent_GetOutputFromBatch
title: NSStream GetOutputFromBatch(Integer batchTaskId)
intellisense: NSBLOBAgent.GetOutputFromBatch
keywords: NSBLOBAgent, GetOutputFromBatch
so.topic: reference
---

Get the output of a batchtask as a stream

**Parameters:**
 - **batchTaskId** The ID of the batchtask that created the output data

**Returns:** NSStream

```crmscript
NSBLOBAgent agent;
Integer batchTaskId;
NSStream res = agent.GetOutputFromBatch(batchTaskId);
```

