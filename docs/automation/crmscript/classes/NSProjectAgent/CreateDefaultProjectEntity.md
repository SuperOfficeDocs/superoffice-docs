---
title: crmscript_ref_NSProjectAgent_CreateDefaultProjectEntity
description: NSProjectEntity CreateDefaultProjectEntity()
intellisense: NSProjectAgent.CreateDefaultProjectEntity
keywords: NSProjectAgent,CreateDefaultProjectEntity
so.topic: reference
---
	  
Set default values into a new NSProjectEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSProjectEntity with default values.

```crmscript
NSProjectAgent agent;
NSProjectEntity thing = agent.CreateDefaultProjectEntity();
thing = agent.SaveProjectEntity(thing);
```

