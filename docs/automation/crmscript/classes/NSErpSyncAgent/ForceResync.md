---
uid: crmscript_ref_NSErpSyncAgent_ForceResync
title: PluginResponse ForceResync(Integer erpConnectionId, IntegerArray internalKeyIds)
intellisense: NSErpSyncAgent.ForceResync
keywords: NSErpSyncAgent, ForceResync
so.topic: reference
---

Force resync from CRM or given Erp connection to all other connections

**Parameters:**
 - **erpConnectionId** If positive, resync from the given erp connection
 - **internalKeyIds** The internal keys of the entities to resync, or empty to resync all

**Returns:** The response

```crmscript
NSErpSyncAgent agent;
Integer erpConnectionId;
IntegerArray internalKeyIds;
PluginResponse res = agent.ForceResync(erpConnectionId, internalKeyIds);
```

