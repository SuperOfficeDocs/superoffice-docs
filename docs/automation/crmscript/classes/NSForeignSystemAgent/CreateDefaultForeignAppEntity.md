---
title: crmscript_ref_NSForeignSystemAgent_CreateDefaultForeignAppEntity
description: NSForeignAppEntity CreateDefaultForeignAppEntity()
intellisense: NSForeignSystemAgent.CreateDefaultForeignAppEntity
keywords: NSForeignSystemAgent,CreateDefaultForeignAppEntity
so.topic: reference
---
	  
Set default values into a new NSForeignAppEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSForeignAppEntity with default values.

```crmscript
NSForeignSystemAgent agent;
NSForeignAppEntity thing = agent.CreateDefaultForeignAppEntity();
thing = agent.SaveForeignAppEntity(thing);
```

