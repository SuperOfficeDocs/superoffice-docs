---
uid: crmscript_ref_NSErpSyncAgent_DeleteConnection
title: Void DeleteConnection(Integer erpConnectionId)
intellisense: NSErpSyncAgent.DeleteConnection
keywords: NSErpSyncAgent, DeleteConnection
so.topic: reference
---

# Void DeleteConnection(Integer erpConnectionId)

Deletes a connection from the database.

**Parameters:**
 - **erpConnectionId** Primary key of the connection

```crmscript
NSErpSyncAgent agent;
Integer erpConnectionId;
agent.DeleteConnection(erpConnectionId);
```

