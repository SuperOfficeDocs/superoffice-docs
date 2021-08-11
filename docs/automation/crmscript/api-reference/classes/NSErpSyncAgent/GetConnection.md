---
uid: crmscript_ref_NSErpSyncAgent_GetConnection
title: NSErpConnection GetConnection(Integer erpConnectionId)
intellisense: NSErpSyncAgent.GetConnection
keywords: NSErpSyncAgent, GetConnection
so.topic: reference
---

# NSErpConnection GetConnection(Integer erpConnectionId)

Returns the specified connection.

**Parameters:**
 - **erpConnectionId** Primary key of the connection

**Returns:** NSErpConnection

```crmscript
NSErpSyncAgent agent;
Integer erpConnectionId;
NSErpConnection res = agent.GetConnection(erpConnectionId);
```

