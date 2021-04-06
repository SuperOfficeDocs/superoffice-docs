---
uid: crmscript_ref_NSPersonAgent_CreateDefaultPersonEntity
title: NSPersonEntity CreateDefaultPersonEntity()
intellisense: NSPersonAgent.CreateDefaultPersonEntity
keywords: NSPersonAgent, CreateDefaultPersonEntity
so.topic: reference
---
	  
Set default values into a new NSPersonEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSPersonEntity with default values.

```crmscript
NSPersonAgent agent;
NSPersonEntity thing = agent.CreateDefaultPersonEntity();
thing = agent.SavePersonEntity(thing);
```

