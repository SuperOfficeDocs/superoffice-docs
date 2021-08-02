---
uid: crmscript_ref_NSContactAgent_CreateDefaultContactEntity
title: NSContactEntity CreateDefaultContactEntity()
intellisense: NSContactAgent.CreateDefaultContactEntity
keywords: NSContactAgent, CreateDefaultContactEntity
so.topic: reference
---
	  
Set default values into a new NSContactEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSContactEntity

```crmscript
NSContactAgent agent;
NSContactEntity thing = agent.CreateDefaultContactEntity();
thing = agent.SaveContactEntity(thing);
```

