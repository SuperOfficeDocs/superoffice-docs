---
uid: crmscript_ref_NSSaintAgent_RegenerateStatusMonitors
title: NSBatchTaskInfo RegenerateStatusMonitors(Bool runAsBatch)
intellisense: NSSaintAgent.RegenerateStatusMonitors
keywords: NSSaintAgent, RegenerateStatusMonitors
so.topic: reference
---

# NSBatchTaskInfo RegenerateStatusMonitors(Bool runAsBatch)

Regenerate status monitors

**Parameters:**
 - **runAsBatch** If true, then execute the regeneration as a Batch Task; the service call will return immediately. Otherwise wait until the task completes, may cause a timeout if called as a Web Service

**Returns:** NSBatchTaskInfo

```crmscript
NSSaintAgent agent;
Bool runAsBatch;
NSBatchTaskInfo res = agent.RegenerateStatusMonitors(runAsBatch);
```

