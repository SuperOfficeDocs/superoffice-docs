---
title: crmscript_ref_NSListAgent_CreateDefaultWebPanelEntity
description: NSWebPanelEntity CreateDefaultWebPanelEntity()
intellisense: NSListAgent.CreateDefaultWebPanelEntity
keywords: NSListAgent,CreateDefaultWebPanelEntity
so.topic: reference
---
	  
Set default values into a new NSWebPanelEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSWebPanelEntity with default values.

```crmscript
NSListAgent agent;
NSWebPanelEntity thing = agent.CreateDefaultWebPanelEntity();
thing = agent.SaveWebPanelEntity(thing);
```

