---
title: crmscript_ref_NSErpSyncAgent_SaveActorTypeMapping
description: ErpSyncActorTypeMapping SaveActorTypeMapping(ErpSyncActorTypeMapping mapping)
intellisense: NSErpSyncAgent.SaveActorTypeMapping
keywords: NSErpSyncAgent,SaveActorTypeMapping
so.topic: reference
---

Save mappings for a connection/actor

**Parameters:**
 - **mapping** The mapping to be saved; new mapping rows will be created in the database if needed

**Returns:** The current mapping from the database

```crmscript
NSErpSyncAgent agent;
ErpSyncActorTypeMapping mapping;
ErpSyncActorTypeMapping res = agent.SaveActorTypeMapping(mapping);
```

