---
uid: crmscript_ref_NSFreeTextAgent_RegenerateIndex
title: NSBatchTaskInfo RegenerateIndex(Bool runAsBatch)
intellisense: NSFreeTextAgent.RegenerateIndex
keywords: NSFreeTextAgent, RegenerateIndex
so.topic: reference
---

# NSBatchTaskInfo RegenerateIndex(Bool runAsBatch)

Wipe and regenerate the freetext index by scanning the database (freetext search will be unavailable while this operation runs

**Parameters:**
 - **runAsBatch** If true, then execute the regeneration as a Batch Task; the service call will return immediately. Otherwise wait until the task completes, may cause a timeout if called as a Web Service

**Returns:** NSBatchTaskInfo

```crmscript
NSFreeTextAgent agent;
Bool runAsBatch;
NSBatchTaskInfo res = agent.RegenerateIndex(runAsBatch);
```

