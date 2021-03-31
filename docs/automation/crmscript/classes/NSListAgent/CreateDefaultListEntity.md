---
title: crmscript_ref_NSListAgent_CreateDefaultListEntity
description: NSListEntity CreateDefaultListEntity()
intellisense: NSListAgent.CreateDefaultListEntity
keywords: NSListAgent,CreateDefaultListEntity
so.topic: reference
---
	  
Set default values into a new NSListEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSListEntity with default values.

```crmscript
NSListAgent agent;
NSListEntity thing = agent.CreateDefaultListEntity();
thing = agent.SaveListEntity(thing);
```

