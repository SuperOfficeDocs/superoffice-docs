---
uid: crmscript_ref_NSErpSyncAgent_CanDeleteErpSyncConnectorEntity
title: Integer CanDeleteErpSyncConnectorEntity(Integer erpSyncConnectorId)
intellisense: NSErpSyncAgent.CanDeleteErpSyncConnectorEntity
keywords: NSErpSyncAgent, CanDeleteErpSyncConnectorEntity
so.topic: reference
---

Can we delete the connector?

**Parameters:**
 - **erpSyncConnectorId** The ID of the ErpSync connector to check if can be deleted

**Returns:** Integer

```crmscript
NSErpSyncAgent agent;
Integer erpSyncConnectorId;
Integer res = agent.CanDeleteErpSyncConnectorEntity(erpSyncConnectorId);
```

