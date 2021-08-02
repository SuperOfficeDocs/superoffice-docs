---
uid: crmscript_ref_NSListAgent_SaveHeadingEntity
title: NSHeadingEntity SaveHeadingEntity(NSHeadingEntity headingEntity);
intellisense: NSListAgent.SaveHeadingEntity
keywords: NSListAgent, SaveHeadingEntity
so.topic: reference
---
	  
Updates the existing NSHeadingEntity or creates a new NSHeadingEntity if the id parameter is 0
	  
**Parameters**:
 - **headingEntity** The NSHeadingEntity to save.

**Returns:** NSHeadingEntity

```crmscript
NSList  agent;
NSHeadingEntity thing = agent.CreateDefaultHeadingEntity();
thing = agent.SaveHeadingEntity(thing);
```

