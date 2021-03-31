---
title: crmscript_ref_NSListAgent_SaveExtAppEntity
description: NSExtAppEntity SaveExtAppEntity(NSExtAppEntity extAppEntity);
intellisense: NSListAgent.SaveExtAppEntity
keywords: NSListAgent,SaveExtAppEntity
so.topic: reference
---
	  
Updates the existing NSExtAppEntity or creates a new NSExtAppEntity if the id parameter is 0
	  
**Parameters**:
 - **extAppEntity** The NSExtAppEntity to save.

**Returns:** New or updated NSExtAppEntity

```crmscript
NSList  agent;
NSExtAppEntity thing = agent.CreateDefaultExtAppEntity();
thing = agent.SaveExtAppEntity(thing);
```

