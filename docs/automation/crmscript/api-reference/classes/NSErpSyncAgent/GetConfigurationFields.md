---
uid: crmscript_ref_NSErpSyncAgent_GetConfigurationFields
title: NSFieldMetadata[] GetConfigurationFields(Integer erpConnectorId)
intellisense: NSErpSyncAgent.GetConfigurationFields
keywords: NSErpSyncAgent, GetConfigurationFields
so.topic: reference
---

# NSFieldMetadata[] GetConfigurationFields(Integer erpConnectorId)

Returns all fields needed to connect to the given connector

**Parameters:**
 - **erpConnectorId** The id of the erp connector

**Returns:** The fields

```crmscript
NSErpSyncAgent agent;
Integer erpConnectorId;
NSFieldMetadata[] res = agent.GetConfigurationFields(erpConnectorId);
```

