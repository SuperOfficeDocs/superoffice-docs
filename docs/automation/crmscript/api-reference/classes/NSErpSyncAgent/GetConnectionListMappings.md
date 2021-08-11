---
uid: crmscript_ref_NSErpSyncAgent_GetConnectionListMappings
title: NSErpConnectionListMappingContainer GetConnectionListMappings(Integer erpConnectionId)
intellisense: NSErpSyncAgent.GetConnectionListMappings
keywords: NSErpSyncAgent, GetConnectionListMappings
so.topic: reference
---

# NSErpConnectionListMappingContainer GetConnectionListMappings(Integer erpConnectionId)

Returns the listmappings for the specified connection.

**Parameters:**
 - **erpConnectionId** Primary key of the connection

**Returns:** NSErpConnectionListMappingContainer

```crmscript
NSErpSyncAgent agent;
Integer erpConnectionId;
NSErpConnectionListMappingContainer res = agent.GetConnectionListMappings(erpConnectionId);
```

