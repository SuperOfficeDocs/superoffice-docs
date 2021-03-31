---
title: crmscript_ref_NSErpSyncAgent_CreateDefaultErpSyncConnectorEntity
description: NSErpSyncConnectorEntity CreateDefaultErpSyncConnectorEntity()
intellisense: NSErpSyncAgent.CreateDefaultErpSyncConnectorEntity
keywords: NSErpSyncAgent,CreateDefaultErpSyncConnectorEntity
so.topic: reference
---
	  
Set default values into a new NSErpSyncConnectorEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSErpSyncConnectorEntity with default values.

```crmscript
NSErpSyncAgent agent;
NSErpSyncConnectorEntity thing = agent.CreateDefaultErpSyncConnectorEntity();
thing = agent.SaveErpSyncConnectorEntity(thing);
```

