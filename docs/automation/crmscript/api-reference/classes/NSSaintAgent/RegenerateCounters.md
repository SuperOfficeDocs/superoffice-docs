---
uid: crmscript_ref_NSSaintAgent_RegenerateCounters
title: NSBatchTaskInfo RegenerateCounters(Bool runAsBatch)
intellisense: NSSaintAgent.RegenerateCounters
keywords: NSSaintAgent, RegenerateCounters
so.topic: reference
---

Regenerate the Saint counters - this can take several minutes

**Parameters:**
 - **runAsBatch** If true, then execute the regeneration as a Batch Task; the service call will return immediately. Otherwise wait until the task completes, may cause a timeout if called as a Web Service

**Returns:** NSBatchTaskInfo

```crmscript
NSSaintAgent agent;
Bool runAsBatch;
NSBatchTaskInfo res = agent.RegenerateCounters(runAsBatch);
```

