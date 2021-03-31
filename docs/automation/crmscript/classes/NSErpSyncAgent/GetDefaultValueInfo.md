---
uid: crmscript_ref_NSErpSyncAgent_GetDefaultValueInfo
title: ErpSyncDefaultValue GetDefaultValueInfo(Integer erpFieldId)
intellisense: NSErpSyncAgent.GetDefaultValueInfo
keywords: NSErpSyncAgent, GetDefaultValueInfo
so.topic: reference
---

Get information about default value for an ERP field

**Parameters:**
 - **erpFieldId** The id of the ERP field

**Returns:** Object with information about default values

```crmscript
NSErpSyncAgent agent;
Integer erpFieldId;
ErpSyncDefaultValue res = agent.GetDefaultValueInfo(erpFieldId);
```

