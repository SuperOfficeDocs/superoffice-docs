---
title: crmscript_ref_NSListAgent_CreateDefaultProjectTypeEntity
description: NSProjectTypeEntity CreateDefaultProjectTypeEntity()
intellisense: NSListAgent.CreateDefaultProjectTypeEntity
keywords: NSListAgent,CreateDefaultProjectTypeEntity
so.topic: reference
---
	  
Set default values into a new NSProjectTypeEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSProjectTypeEntity with default values.

```crmscript
NSListAgent agent;
NSProjectTypeEntity thing = agent.CreateDefaultProjectTypeEntity();
thing = agent.SaveProjectTypeEntity(thing);
```

