---
title: crmscript_ref_NSUserAgent_CreateDefaultRoleEntity
description: NSRoleEntity CreateDefaultRoleEntity()
intellisense: NSUserAgent.CreateDefaultRoleEntity
keywords: NSUserAgent,CreateDefaultRoleEntity
so.topic: reference
---
	  
Set default values into a new NSRoleEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSRoleEntity with default values.

```crmscript
NSUserAgent agent;
NSRoleEntity thing = agent.CreateDefaultRoleEntity();
thing = agent.SaveRoleEntity(thing);
```

