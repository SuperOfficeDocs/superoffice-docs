---
title: crmscript_ref_NSListAgent_CreateDefaultHeadingEntity
description: NSHeadingEntity CreateDefaultHeadingEntity()
intellisense: NSListAgent.CreateDefaultHeadingEntity
keywords: NSListAgent,CreateDefaultHeadingEntity
so.topic: reference
---
	  
Set default values into a new NSHeadingEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSHeadingEntity with default values.

```crmscript
NSListAgent agent;
NSHeadingEntity thing = agent.CreateDefaultHeadingEntity();
thing = agent.SaveHeadingEntity(thing);
```

