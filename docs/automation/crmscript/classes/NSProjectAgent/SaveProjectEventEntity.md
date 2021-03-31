---
title: crmscript_ref_NSProjectAgent_SaveProjectEventEntity
description: NSProjectEventEntity SaveProjectEventEntity(NSProjectEventEntity projectEventEntity);
intellisense: NSProjectAgent.SaveProjectEventEntity
keywords: NSProjectAgent,SaveProjectEventEntity
so.topic: reference
---
	  
Updates the existing NSProjectEventEntity or creates a new NSProjectEventEntity if the id parameter is 0
	  
**Parameters**:
 - **projectEventEntity** The NSProjectEventEntity to save.

**Returns:** New or updated NSProjectEventEntity

```crmscript
NSProject  agent;
NSProjectEventEntity thing = agent.CreateDefaultProjectEventEntity();
thing = agent.SaveProjectEventEntity(thing);
```

