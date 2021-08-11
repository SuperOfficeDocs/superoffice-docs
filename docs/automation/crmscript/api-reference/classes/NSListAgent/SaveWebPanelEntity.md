---
uid: crmscript_ref_NSListAgent_SaveWebPanelEntity
title: NSWebPanelEntity SaveWebPanelEntity(NSWebPanelEntity webPanelEntity);
intellisense: NSListAgent.SaveWebPanelEntity
keywords: NSListAgent, SaveWebPanelEntity
so.topic: reference
---

# NSWebPanelEntity SaveWebPanelEntity(NSWebPanelEntity webPanelEntity);
	  
Updates the existing NSWebPanelEntity or creates a new NSWebPanelEntity if the id parameter is 0
	  
**Parameters**:
 - **webPanelEntity** The NSWebPanelEntity to save.

**Returns:** NSWebPanelEntity

```crmscript
NSList  agent;
NSWebPanelEntity thing = agent.CreateDefaultWebPanelEntity();
thing = agent.SaveWebPanelEntity(thing);
```

