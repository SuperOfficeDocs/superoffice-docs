---
uid: crmscript_ref_NSListAgent_CreateDefaultWebPanelEntity
title: NSWebPanelEntity CreateDefaultWebPanelEntity()
intellisense: NSListAgent.CreateDefaultWebPanelEntity
keywords: NSListAgent, CreateDefaultWebPanelEntity
so.topic: reference
---

# NSWebPanelEntity CreateDefaultWebPanelEntity()
	  
Set default values into a new NSWebPanelEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSWebPanelEntity

```crmscript
NSListAgent agent;
NSWebPanelEntity thing = agent.CreateDefaultWebPanelEntity();
thing = agent.SaveWebPanelEntity(thing);
```

