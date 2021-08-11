---
uid: crmscript_ref_NSListAgent_SaveProjectTypeEntity
title: NSProjectTypeEntity SaveProjectTypeEntity(NSProjectTypeEntity projectTypeEntity);
intellisense: NSListAgent.SaveProjectTypeEntity
keywords: NSListAgent, SaveProjectTypeEntity
so.topic: reference
---

# NSProjectTypeEntity SaveProjectTypeEntity(NSProjectTypeEntity projectTypeEntity);
	  
Updates the existing NSProjectTypeEntity or creates a new NSProjectTypeEntity if the id parameter is 0
	  
**Parameters**:
 - **projectTypeEntity** The NSProjectTypeEntity to save.

**Returns:** NSProjectTypeEntity

```crmscript
NSList  agent;
NSProjectTypeEntity thing = agent.CreateDefaultProjectTypeEntity();
thing = agent.SaveProjectTypeEntity(thing);
```

