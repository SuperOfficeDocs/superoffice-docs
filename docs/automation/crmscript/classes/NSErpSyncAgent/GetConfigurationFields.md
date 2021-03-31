---
title: crmscript_ref_NSErpSyncAgent_GetConfigurationFields
description: FieldMetadataArray GetConfigurationFields(Integer erpConnectorId)
intellisense: NSErpSyncAgent.GetConfigurationFields
keywords: NSErpSyncAgent,GetConfigurationFields
so.topic: reference
---

Returns all fields needed to connect to the given connector

**Parameters:**
 - **erpConnectorId** The id of the erp connector

**Returns:** The fields

```crmscript
NSErpSyncAgent agent;
Integer erpConnectorId;
FieldMetadataArray res = agent.GetConfigurationFields(erpConnectorId);
```

