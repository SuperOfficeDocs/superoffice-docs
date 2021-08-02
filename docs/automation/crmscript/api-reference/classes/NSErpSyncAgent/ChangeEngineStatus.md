---
uid: crmscript_ref_NSErpSyncAgent_ChangeEngineStatus
title: NSErpSyncEngineStatus ChangeEngineStatus(Bool run)
intellisense: NSErpSyncAgent.ChangeEngineStatus
keywords: NSErpSyncAgent, ChangeEngineStatus
so.topic: reference
---

Change the current running/stopped status of the Sync engine

**Parameters:**
 - **run** If true, then start the engine; otherwise stop it (requests to the Batch system, may not be immediately reflected)

**Returns:** NSErpSyncEngineStatus

```crmscript
NSErpSyncAgent agent;
Bool run;
NSErpSyncEngineStatus res = agent.ChangeEngineStatus(run);
```

