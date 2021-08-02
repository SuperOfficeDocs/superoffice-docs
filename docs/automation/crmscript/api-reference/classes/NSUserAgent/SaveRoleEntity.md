---
uid: crmscript_ref_NSUserAgent_SaveRoleEntity
title: NSRoleEntity SaveRoleEntity(NSRoleEntity roleEntity);
intellisense: NSUserAgent.SaveRoleEntity
keywords: NSUserAgent, SaveRoleEntity
so.topic: reference
---
	  
Updates the existing NSRoleEntity or creates a new NSRoleEntity if the id parameter is 0
	  
**Parameters**:
 - **roleEntity** The NSRoleEntity to save.

**Returns:** NSRoleEntity

```crmscript
NSUser  agent;
NSRoleEntity thing = agent.CreateDefaultRoleEntity();
thing = agent.SaveRoleEntity(thing);
```

