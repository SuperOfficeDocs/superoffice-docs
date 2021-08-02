---
uid: crmscript_ref_NSErpSyncAgent_SaveActorTypeMapping
title: NSErpSyncActorTypeMapping SaveActorTypeMapping(NSErpSyncActorTypeMapping mapping)
intellisense: NSErpSyncAgent.SaveActorTypeMapping
keywords: NSErpSyncAgent, SaveActorTypeMapping
so.topic: reference
---

Save mappings for a connection/actor

**Parameters:**
 - **mapping** The mapping to be saved; new mapping rows will be created in the database if needed

**Returns:** NSErpSyncActorTypeMapping

```crmscript
NSErpSyncAgent agent;
NSErpSyncActorTypeMapping mapping;
NSErpSyncActorTypeMapping res = agent.SaveActorTypeMapping(mapping);
```

