---
uid: crmscript_ref_NSErpSyncAgent_GetErpSyncConnectionSummary
title: NSErpSyncConnectionSummary GetErpSyncConnectionSummary(Integer erpSyncConnectionId)
intellisense: NSErpSyncAgent.GetErpSyncConnectionSummary
keywords: NSErpSyncAgent, GetErpSyncConnectionSummary
so.topic: reference
---

Get a summary of the current ErpSync configuration/setup

**Parameters:**
 - **erpSyncConnectionId** The ID of the ErpSync connection for which information is sought

**Returns:** NSErpSyncConnectionSummary

```crmscript
NSErpSyncAgent agent;
Integer erpSyncConnectionId;
NSErpSyncConnectionSummary res = agent.GetErpSyncConnectionSummary(erpSyncConnectionId);
```

