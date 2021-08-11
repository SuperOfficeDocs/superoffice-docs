---
uid: crmscript_ref_NSErpSyncAgent_CreateDefaultErpSyncConnectorEntity
title: NSErpSyncConnectorEntity CreateDefaultErpSyncConnectorEntity()
intellisense: NSErpSyncAgent.CreateDefaultErpSyncConnectorEntity
keywords: NSErpSyncAgent, CreateDefaultErpSyncConnectorEntity
so.topic: reference
---

# NSErpSyncConnectorEntity CreateDefaultErpSyncConnectorEntity()
	  
Set default values into a new NSErpSyncConnectorEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSErpSyncConnectorEntity

```crmscript
NSErpSyncAgent agent;
NSErpSyncConnectorEntity thing = agent.CreateDefaultErpSyncConnectorEntity();
thing = agent.SaveErpSyncConnectorEntity(thing);
```

