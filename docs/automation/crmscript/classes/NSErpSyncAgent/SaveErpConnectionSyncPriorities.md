---
uid: crmscript_ref_NSErpSyncAgent_SaveErpConnectionSyncPriorities
title: Bool SaveErpConnectionSyncPriorities(IntegerArray erpConnectionIds)
intellisense: NSErpSyncAgent.SaveErpConnectionSyncPriorities
keywords: NSErpSyncAgent, SaveErpConnectionSyncPriorities
so.topic: reference
---

Takes an array of the ErpConnection ids and saves these as ordered sync priorities

**Parameters:**
 - **erpConnectionIds** The id put in array in the same order as the priorities

**Returns:** Returns true if new sync priorities is saved

```crmscript
NSErpSyncAgent agent;
IntegerArray erpConnectionIds;
Bool res = agent.SaveErpConnectionSyncPriorities(erpConnectionIds);
```

