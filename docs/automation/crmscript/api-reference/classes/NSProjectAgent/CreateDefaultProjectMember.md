---
uid: crmscript_ref_NSProjectAgent_CreateDefaultProjectMember
title: NSProjectMember CreateDefaultProjectMember()
intellisense: NSProjectAgent.CreateDefaultProjectMember
keywords: NSProjectAgent, CreateDefaultProjectMember
so.topic: reference
---

# NSProjectMember CreateDefaultProjectMember()
	  
Set default values into a new NSProjectMember.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSProjectMember

```crmscript
NSProjectAgent agent;
NSProjectMember thing = agent.CreateDefaultProjectMember();
thing = agent.SaveProjectMember(thing);
```

