---
title: crmscript_ref_NSProjectAgent_CreateDefaultProjectEventEntity
description: NSProjectEventEntity CreateDefaultProjectEventEntity()
intellisense: NSProjectAgent.CreateDefaultProjectEventEntity
keywords: NSProjectAgent,CreateDefaultProjectEventEntity
so.topic: reference
---
	  
Set default values into a new NSProjectEventEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSProjectEventEntity with default values.

```crmscript
NSProjectAgent agent;
NSProjectEventEntity thing = agent.CreateDefaultProjectEventEntity();
thing = agent.SaveProjectEventEntity(thing);
```

