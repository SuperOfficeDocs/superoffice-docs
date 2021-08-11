---
uid: crmscript_ref_NSErpSyncAgent_SaveErpConnectionSyncPriorities
title: Bool SaveErpConnectionSyncPriorities(Integer[] erpConnectionIds)
intellisense: NSErpSyncAgent.SaveErpConnectionSyncPriorities
keywords: NSErpSyncAgent, SaveErpConnectionSyncPriorities
so.topic: reference
---

# Bool SaveErpConnectionSyncPriorities(Integer[] erpConnectionIds)

Takes an array of the ErpConnection ids and saves these as ordered sync priorities

**Parameters:**
 - **erpConnectionIds** The id put in array in the same order as the priorities

**Returns:** Bool

```crmscript
NSErpSyncAgent agent;
Integer[] erpConnectionIds;
Bool res = agent.SaveErpConnectionSyncPriorities(erpConnectionIds);
```

