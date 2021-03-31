---
title: crmscript_ref_NSFreeTextAgent_RegenerateIndex
description: BatchTaskInfo RegenerateIndex(Bool runAsBatch)
intellisense: NSFreeTextAgent.RegenerateIndex
keywords: NSFreeTextAgent,RegenerateIndex
so.topic: reference
---

Wipe and regenerate the freetext index by scanning the database (freetext search will be unavailable while this operation runs

**Parameters:**
 - **runAsBatch** If true, then execute the regeneration as a Batch Task; the service call will return immediately. Otherwise wait until the task completes, may cause a timeout if called as a Web Service

**Returns:** Information about the batch task, if batch execution was requested. Otherwise null

```crmscript
NSFreeTextAgent agent;
Bool runAsBatch;
BatchTaskInfo res = agent.RegenerateIndex(runAsBatch);
```

