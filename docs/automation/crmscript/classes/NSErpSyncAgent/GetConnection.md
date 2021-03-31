---
title: crmscript_ref_NSErpSyncAgent_GetConnection
description: ErpConnection GetConnection(Integer erpConnectionId)
intellisense: NSErpSyncAgent.GetConnection
keywords: NSErpSyncAgent,GetConnection
so.topic: reference
---

Returns the specified connection.

**Parameters:**
 - **erpConnectionId** Primary key of the connection

**Returns:** The connection

```crmscript
NSErpSyncAgent agent;
Integer erpConnectionId;
ErpConnection res = agent.GetConnection(erpConnectionId);
```

