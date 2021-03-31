---
uid: crmscript_ref_NSBLOBAgent_GetOutputFromBatch
title: Stream GetOutputFromBatch(Integer batchTaskId)
intellisense: NSBLOBAgent.GetOutputFromBatch
keywords: NSBLOBAgent, GetOutputFromBatch
so.topic: reference
---

Get the output of a batchtask as a stream

**Parameters:**
 - **batchTaskId** The ID of the batchtask that created the output data

**Returns:** The binary object as a Stream

```crmscript
NSBLOBAgent agent;
Integer batchTaskId;
Stream res = agent.GetOutputFromBatch(batchTaskId);
```

