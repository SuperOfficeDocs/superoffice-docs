---
uid: crmscript_ref_NSListAgent_CreateDefaultHeadingEntity
title: NSHeadingEntity CreateDefaultHeadingEntity()
intellisense: NSListAgent.CreateDefaultHeadingEntity
keywords: NSListAgent, CreateDefaultHeadingEntity
so.topic: reference
---
	  
Set default values into a new NSHeadingEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSHeadingEntity

```crmscript
NSListAgent agent;
NSHeadingEntity thing = agent.CreateDefaultHeadingEntity();
thing = agent.SaveHeadingEntity(thing);
```

