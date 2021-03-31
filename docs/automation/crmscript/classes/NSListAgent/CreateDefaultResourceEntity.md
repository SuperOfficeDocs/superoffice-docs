---
uid: crmscript_ref_NSListAgent_CreateDefaultResourceEntity
title: NSResourceEntity CreateDefaultResourceEntity()
intellisense: NSListAgent.CreateDefaultResourceEntity
keywords: NSListAgent, CreateDefaultResourceEntity
so.topic: reference
---
	  
Set default values into a new NSResourceEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSResourceEntity with default values.

```crmscript
NSListAgent agent;
NSResourceEntity thing = agent.CreateDefaultResourceEntity();
thing = agent.SaveResourceEntity(thing);
```

