---
uid: crmscript_ref_NSListAgent_CreateDefaultRelationDefinitionEntity
title: NSRelationDefinitionEntity CreateDefaultRelationDefinitionEntity()
intellisense: NSListAgent.CreateDefaultRelationDefinitionEntity
keywords: NSListAgent, CreateDefaultRelationDefinitionEntity
so.topic: reference
---

# NSRelationDefinitionEntity CreateDefaultRelationDefinitionEntity()
	  
Set default values into a new NSRelationDefinitionEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSRelationDefinitionEntity

```crmscript
NSListAgent agent;
NSRelationDefinitionEntity thing = agent.CreateDefaultRelationDefinitionEntity();
thing = agent.SaveRelationDefinitionEntity(thing);
```

