---
uid: crmscript_ref_NSErpSyncAgent_UpdateConnectionFields
title: Bool UpdateConnectionFields(Integer erpConnectionId)
intellisense: NSErpSyncAgent.UpdateConnectionFields
keywords: NSErpSyncAgent, UpdateConnectionFields
so.topic: reference
---

# Bool UpdateConnectionFields(Integer erpConnectionId)

Gets all supported actor types, and all fields for each actor type, and save this state to the CRM database

**Parameters:**
 - **erpConnectionId** The ERP connection ID

**Returns:** Bool

```crmscript
NSErpSyncAgent agent;
Integer erpConnectionId;
Bool res = agent.UpdateConnectionFields(erpConnectionId);
```

