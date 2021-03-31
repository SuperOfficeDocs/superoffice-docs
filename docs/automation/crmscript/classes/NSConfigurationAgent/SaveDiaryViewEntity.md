---
uid: crmscript_ref_NSConfigurationAgent_SaveDiaryViewEntity
title: NSDiaryViewEntity SaveDiaryViewEntity(NSDiaryViewEntity diaryViewEntity);
intellisense: NSConfigurationAgent.SaveDiaryViewEntity
keywords: NSConfigurationAgent, SaveDiaryViewEntity
so.topic: reference
---
	  
Updates the existing NSDiaryViewEntity or creates a new NSDiaryViewEntity if the id parameter is 0
	  
**Parameters**:
 - **diaryViewEntity** The NSDiaryViewEntity to save.

**Returns:** New or updated NSDiaryViewEntity

```crmscript
NSConfiguration  agent;
NSDiaryViewEntity thing = agent.CreateDefaultDiaryViewEntity();
thing = agent.SaveDiaryViewEntity(thing);
```

