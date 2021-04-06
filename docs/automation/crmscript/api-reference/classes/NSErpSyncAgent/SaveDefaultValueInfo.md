---
uid: crmscript_ref_NSErpSyncAgent_SaveDefaultValueInfo
title: ErpSyncDefaultValue SaveDefaultValueInfo(ErpSyncDefaultValue erpSyncDefaultValue)
intellisense: NSErpSyncAgent.SaveDefaultValueInfo
keywords: NSErpSyncAgent, SaveDefaultValueInfo
so.topic: reference
---

Save information about a default value for an ERP field

**Parameters:**
 - **erpSyncDefaultValue** The id of the ERPfield to save

**Returns:** The newly saved ErpSyncDefaultValue

```crmscript
NSErpSyncAgent agent;
ErpSyncDefaultValue erpSyncDefaultValue;
ErpSyncDefaultValue res = agent.SaveDefaultValueInfo(erpSyncDefaultValue);
```

