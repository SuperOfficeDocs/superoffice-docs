---
title: crmscript_ref_NSErpSyncAgent_GetConnectionListMappings
description: ErpConnectionListMappingContainer GetConnectionListMappings(Integer erpConnectionId)
intellisense: NSErpSyncAgent.GetConnectionListMappings
keywords: NSErpSyncAgent,GetConnectionListMappings
so.topic: reference
---

Returns the listmappings for the specified connection.

**Parameters:**
 - **erpConnectionId** Primary key of the connection

**Returns:** The listmappings

```crmscript
NSErpSyncAgent agent;
Integer erpConnectionId;
ErpConnectionListMappingContainer res = agent.GetConnectionListMappings(erpConnectionId);
```

