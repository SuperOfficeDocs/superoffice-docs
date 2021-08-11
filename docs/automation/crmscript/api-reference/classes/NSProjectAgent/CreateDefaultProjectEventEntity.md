---
uid: crmscript_ref_NSProjectAgent_CreateDefaultProjectEventEntity
title: NSProjectEventEntity CreateDefaultProjectEventEntity()
intellisense: NSProjectAgent.CreateDefaultProjectEventEntity
keywords: NSProjectAgent, CreateDefaultProjectEventEntity
so.topic: reference
---

# NSProjectEventEntity CreateDefaultProjectEventEntity()
	  
Set default values into a new NSProjectEventEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSProjectEventEntity

```crmscript
NSProjectAgent agent;
NSProjectEventEntity thing = agent.CreateDefaultProjectEventEntity();
thing = agent.SaveProjectEventEntity(thing);
```

