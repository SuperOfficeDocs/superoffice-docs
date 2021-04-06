---
uid: crmscript_ref_NSErpSyncAgent_GetErpConnectionConfigFields
title: StringDictionary GetErpConnectionConfigFields(Integer erpConnectionId)
intellisense: NSErpSyncAgent.GetErpConnectionConfigFields
keywords: NSErpSyncAgent, GetErpConnectionConfigFields
so.topic: reference
---

Returns the config fields for the connection.

**Parameters:**
 - **erpConnectionId** Primary key of the erp connection

**Returns:** Config Fields

```crmscript
NSErpSyncAgent agent;
Integer erpConnectionId;
StringDictionary res = agent.GetErpConnectionConfigFields(erpConnectionId);
```

