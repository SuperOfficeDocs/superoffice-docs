---
title: crmscript_ref_NSErpSyncAgent_ChangeEngineStatus
description: ErpSyncEngineStatus ChangeEngineStatus(Bool run)
intellisense: NSErpSyncAgent.ChangeEngineStatus
keywords: NSErpSyncAgent,ChangeEngineStatus
so.topic: reference
---

Change the current running/stopped status of the Sync engine

**Parameters:**
 - **run** If true, then start the engine; otherwise stop it (requests to the Batch system, may not be immediately reflected)

**Returns:** The current status of the engine

```crmscript
NSErpSyncAgent agent;
Bool run;
ErpSyncEngineStatus res = agent.ChangeEngineStatus(run);
```

