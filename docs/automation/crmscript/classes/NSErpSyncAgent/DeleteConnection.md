---
title: crmscript_ref_NSErpSyncAgent_DeleteConnection
description: Void DeleteConnection(Integer erpConnectionId)
intellisense: NSErpSyncAgent.DeleteConnection
keywords: NSErpSyncAgent,DeleteConnection
so.topic: reference
---

Deletes a connection from the database.

**Parameters:**
 - **erpConnectionId** Primary key of the connection

**Returns:** A void return

```crmscript
NSErpSyncAgent agent;
Integer erpConnectionId;
Void res = agent.DeleteConnection(erpConnectionId);
```

