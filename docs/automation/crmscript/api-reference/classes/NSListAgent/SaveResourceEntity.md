---
uid: crmscript_ref_NSListAgent_SaveResourceEntity
title: NSResourceEntity SaveResourceEntity(NSResourceEntity resourceEntity);
intellisense: NSListAgent.SaveResourceEntity
keywords: NSListAgent, SaveResourceEntity
so.topic: reference
---
	  
Updates the existing NSResourceEntity or creates a new NSResourceEntity if the id parameter is 0
	  
**Parameters**:
 - **resourceEntity** The NSResourceEntity to save.

**Returns:** New or updated NSResourceEntity

```crmscript
NSList  agent;
NSResourceEntity thing = agent.CreateDefaultResourceEntity();
thing = agent.SaveResourceEntity(thing);
```

