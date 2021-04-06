---
uid: crmscript_ref_NSRelationAgent_CreateDefaultContactRelationEntity
title: NSContactRelationEntity CreateDefaultContactRelationEntity()
intellisense: NSRelationAgent.CreateDefaultContactRelationEntity
keywords: NSRelationAgent, CreateDefaultContactRelationEntity
so.topic: reference
---
	  
Set default values into a new NSContactRelationEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSContactRelationEntity with default values.

```crmscript
NSRelationAgent agent;
NSContactRelationEntity thing = agent.CreateDefaultContactRelationEntity();
thing = agent.SaveContactRelationEntity(thing);
```

