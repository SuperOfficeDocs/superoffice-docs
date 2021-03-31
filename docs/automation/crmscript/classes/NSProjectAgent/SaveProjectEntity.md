---
title: crmscript_ref_NSProjectAgent_SaveProjectEntity
description: NSProjectEntity SaveProjectEntity(NSProjectEntity projectEntity);
intellisense: NSProjectAgent.SaveProjectEntity
keywords: NSProjectAgent,SaveProjectEntity
so.topic: reference
---
	  
Updates the existing NSProjectEntity or creates a new NSProjectEntity if the id parameter is 0
	  
**Parameters**:
 - **projectEntity** The NSProjectEntity to save.

**Returns:** New or updated NSProjectEntity

```crmscript
NSProject  agent;
NSProjectEntity thing = agent.CreateDefaultProjectEntity();
thing = agent.SaveProjectEntity(thing);
```

