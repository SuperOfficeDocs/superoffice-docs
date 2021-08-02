---
uid: crmscript_ref_NSConfigurationAgent_CreateDefaultDiaryViewEntity
title: NSDiaryViewEntity CreateDefaultDiaryViewEntity()
intellisense: NSConfigurationAgent.CreateDefaultDiaryViewEntity
keywords: NSConfigurationAgent, CreateDefaultDiaryViewEntity
so.topic: reference
---
	  
Set default values into a new NSDiaryViewEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSDiaryViewEntity

```crmscript
NSConfigurationAgent agent;
NSDiaryViewEntity thing = agent.CreateDefaultDiaryViewEntity();
thing = agent.SaveDiaryViewEntity(thing);
```

