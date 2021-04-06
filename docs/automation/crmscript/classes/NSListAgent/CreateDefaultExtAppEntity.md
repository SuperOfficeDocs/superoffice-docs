---
uid: crmscript_ref_NSListAgent_CreateDefaultExtAppEntity
title: NSExtAppEntity CreateDefaultExtAppEntity()
intellisense: NSListAgent.CreateDefaultExtAppEntity
keywords: NSListAgent, CreateDefaultExtAppEntity
so.topic: reference
---
	  
Set default values into a new NSExtAppEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSExtAppEntity with default values.

```crmscript
NSListAgent agent;
NSExtAppEntity thing = agent.CreateDefaultExtAppEntity();
thing = agent.SaveExtAppEntity(thing);
```

