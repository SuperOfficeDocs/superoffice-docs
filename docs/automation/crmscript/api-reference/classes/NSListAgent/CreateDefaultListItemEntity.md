---
uid: crmscript_ref_NSListAgent_CreateDefaultListItemEntity
title: NSListItemEntity CreateDefaultListItemEntity()
intellisense: NSListAgent.CreateDefaultListItemEntity
keywords: NSListAgent, CreateDefaultListItemEntity
so.topic: reference
---
	  
Set default values into a new NSListItemEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSListItemEntity

```crmscript
NSListAgent agent;
NSListItemEntity thing = agent.CreateDefaultListItemEntity();
thing = agent.SaveListItemEntity(thing);
```

