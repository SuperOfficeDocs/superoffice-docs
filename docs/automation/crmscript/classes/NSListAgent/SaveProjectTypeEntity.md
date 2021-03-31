---
title: crmscript_ref_NSListAgent_SaveProjectTypeEntity
description: NSProjectTypeEntity SaveProjectTypeEntity(NSProjectTypeEntity projectTypeEntity);
intellisense: NSListAgent.SaveProjectTypeEntity
keywords: NSListAgent,SaveProjectTypeEntity
so.topic: reference
---
	  
Updates the existing NSProjectTypeEntity or creates a new NSProjectTypeEntity if the id parameter is 0
	  
**Parameters**:
 - **projectTypeEntity** The NSProjectTypeEntity to save.

**Returns:** New or updated NSProjectTypeEntity

```crmscript
NSList  agent;
NSProjectTypeEntity thing = agent.CreateDefaultProjectTypeEntity();
thing = agent.SaveProjectTypeEntity(thing);
```

