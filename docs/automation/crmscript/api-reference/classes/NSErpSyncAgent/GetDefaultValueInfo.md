---
uid: crmscript_ref_NSErpSyncAgent_GetDefaultValueInfo
title: NSErpSyncDefaultValue GetDefaultValueInfo(Integer erpFieldId)
intellisense: NSErpSyncAgent.GetDefaultValueInfo
keywords: NSErpSyncAgent, GetDefaultValueInfo
so.topic: reference
---

# NSErpSyncDefaultValue GetDefaultValueInfo(Integer erpFieldId)

Get information about default value for an ERP field

**Parameters:**
 - **erpFieldId** The id of the ERP field

**Returns:** NSErpSyncDefaultValue

```crmscript
NSErpSyncAgent agent;
Integer erpFieldId;
NSErpSyncDefaultValue res = agent.GetDefaultValueInfo(erpFieldId);
```

