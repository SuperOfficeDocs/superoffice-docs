---
title: crmscript_ref_NSListAgent_SaveWebPanelEntity
description: NSWebPanelEntity SaveWebPanelEntity(NSWebPanelEntity webPanelEntity);
intellisense: NSListAgent.SaveWebPanelEntity
keywords: NSListAgent,SaveWebPanelEntity
so.topic: reference
---
	  
Updates the existing NSWebPanelEntity or creates a new NSWebPanelEntity if the id parameter is 0
	  
**Parameters**:
 - **webPanelEntity** The NSWebPanelEntity to save.

**Returns:** New or updated NSWebPanelEntity

```crmscript
NSList  agent;
NSWebPanelEntity thing = agent.CreateDefaultWebPanelEntity();
thing = agent.SaveWebPanelEntity(thing);
```

