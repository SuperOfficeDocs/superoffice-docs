---
title: crmscript_ref_NSListAgent_CreateDefaultSaleTypeEntity
description: NSSaleTypeEntity CreateDefaultSaleTypeEntity()
intellisense: NSListAgent.CreateDefaultSaleTypeEntity
keywords: NSListAgent,CreateDefaultSaleTypeEntity
so.topic: reference
---
	  
Set default values into a new NSSaleTypeEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSSaleTypeEntity with default values.

```crmscript
NSListAgent agent;
NSSaleTypeEntity thing = agent.CreateDefaultSaleTypeEntity();
thing = agent.SaveSaleTypeEntity(thing);
```

