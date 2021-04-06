---
uid: crmscript_ref_NSErpSyncAgent_SaveErpSyncConnectorEntity
title: NSErpSyncConnectorEntity SaveErpSyncConnectorEntity(NSErpSyncConnectorEntity erpSyncConnectorEntity);
intellisense: NSErpSyncAgent.SaveErpSyncConnectorEntity
keywords: NSErpSyncAgent, SaveErpSyncConnectorEntity
so.topic: reference
---
	  
Updates the existing NSErpSyncConnectorEntity or creates a new NSErpSyncConnectorEntity if the id parameter is 0
	  
**Parameters**:
 - **erpSyncConnectorEntity** The NSErpSyncConnectorEntity to save.

**Returns:** New or updated NSErpSyncConnectorEntity

```crmscript
NSErpSync  agent;
NSErpSyncConnectorEntity thing = agent.CreateDefaultErpSyncConnectorEntity();
thing = agent.SaveErpSyncConnectorEntity(thing);
```

