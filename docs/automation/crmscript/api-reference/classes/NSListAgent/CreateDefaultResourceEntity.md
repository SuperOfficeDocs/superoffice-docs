---
uid: crmscript_ref_NSListAgent_CreateDefaultResourceEntity
title: NSResourceEntity CreateDefaultResourceEntity()
intellisense: NSListAgent.CreateDefaultResourceEntity
keywords: NSListAgent, CreateDefaultResourceEntity
so.topic: reference
---

# NSResourceEntity CreateDefaultResourceEntity()
	  
Set default values into a new NSResourceEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSResourceEntity

```crmscript
NSListAgent agent;
NSResourceEntity thing = agent.CreateDefaultResourceEntity();
thing = agent.SaveResourceEntity(thing);
```

