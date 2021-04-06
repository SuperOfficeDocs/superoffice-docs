---
uid: crmscript_ref_NSErpSyncAgent_TestConnectionById
title: Bool TestConnectionById(Integer erpConnectionId)
intellisense: NSErpSyncAgent.TestConnectionById
keywords: NSErpSyncAgent, TestConnectionById
so.topic: reference
---

Tests to see if we can establish a connection with the given config fields

**Parameters:**
 - **erpConnectionId** The id of the connection

**Returns:** Returns true if success

```crmscript
NSErpSyncAgent agent;
Integer erpConnectionId;
Bool res = agent.TestConnectionById(erpConnectionId);
```

