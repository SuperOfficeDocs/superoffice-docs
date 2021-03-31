---
title: crmscript_ref_NSListAgent_CreateDefaultSaleStageEntity
description: NSSaleStageEntity CreateDefaultSaleStageEntity()
intellisense: NSListAgent.CreateDefaultSaleStageEntity
keywords: NSListAgent,CreateDefaultSaleStageEntity
so.topic: reference
---
	  
Set default values into a new NSSaleStageEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSSaleStageEntity with default values.

```crmscript
NSListAgent agent;
NSSaleStageEntity thing = agent.CreateDefaultSaleStageEntity();
thing = agent.SaveSaleStageEntity(thing);
```

