---
uid: crmscript_ref_NSConfigurationAgent_CreateDefaultSystemEventEntity
title: NSSystemEventEntity CreateDefaultSystemEventEntity()
intellisense: NSConfigurationAgent.CreateDefaultSystemEventEntity
keywords: NSConfigurationAgent, CreateDefaultSystemEventEntity
so.topic: reference
---

# NSSystemEventEntity CreateDefaultSystemEventEntity()
	  
Set default values into a new NSSystemEventEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSSystemEventEntity

```crmscript
NSConfigurationAgent agent;
NSSystemEventEntity thing = agent.CreateDefaultSystemEventEntity();
thing = agent.SaveSystemEventEntity(thing);
```

