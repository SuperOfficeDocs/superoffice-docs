---
uid: crmscript_ref_NSErpSyncAgent_GetErpSyncConnectionSummary
title: ErpSyncConnectionSummary GetErpSyncConnectionSummary(Integer erpSyncConnectionId)
intellisense: NSErpSyncAgent.GetErpSyncConnectionSummary
keywords: NSErpSyncAgent, GetErpSyncConnectionSummary
so.topic: reference
---

Get a summary of the current ErpSync configuration/setup

**Parameters:**
 - **erpSyncConnectionId** The ID of the ErpSync connection for which information is sought

**Returns:** Summary of connection information, and one summary element per configured actor type

```crmscript
NSErpSyncAgent agent;
Integer erpSyncConnectionId;
ErpSyncConnectionSummary res = agent.GetErpSyncConnectionSummary(erpSyncConnectionId);
```

