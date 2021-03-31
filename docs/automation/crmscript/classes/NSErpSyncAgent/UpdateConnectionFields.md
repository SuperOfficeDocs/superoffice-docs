---
title: crmscript_ref_NSErpSyncAgent_UpdateConnectionFields
description: Bool UpdateConnectionFields(Integer erpConnectionId)
intellisense: NSErpSyncAgent.UpdateConnectionFields
keywords: NSErpSyncAgent,UpdateConnectionFields
so.topic: reference
---

Gets all supported actor types, and all fields for each actor type, and save this state to the CRM database

**Parameters:**
 - **erpConnectionId** The ERP connection ID

**Returns:** Success or fail

```crmscript
NSErpSyncAgent agent;
Integer erpConnectionId;
Bool res = agent.UpdateConnectionFields(erpConnectionId);
```

