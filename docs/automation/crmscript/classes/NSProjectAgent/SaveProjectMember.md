---
title: crmscript_ref_NSProjectAgent_SaveProjectMember
description: NSProjectMember SaveProjectMember(NSProjectMember projectMember);
intellisense: NSProjectAgent.SaveProjectMember
keywords: NSProjectAgent,SaveProjectMember
so.topic: reference
---
	  
Updates the existing NSProjectMember or creates a new NSProjectMember if the id parameter is 0
	  
**Parameters**:
 - **projectMember** The NSProjectMember to save.

**Returns:** New or updated NSProjectMember

```crmscript
NSProject  agent;
NSProjectMember thing = agent.CreateDefaultProjectMember();
thing = agent.SaveProjectMember(thing);
```

