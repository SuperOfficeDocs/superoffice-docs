---
title: crmscript_ref_NSUserAgent_CreateDefaultUser
description: NSUser CreateDefaultUser()
intellisense: NSUserAgent.CreateDefaultUser
keywords: NSUserAgent,CreateDefaultUser
so.topic: reference
---
	  
Set default values into a new NSUser.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSUser with default values.

```crmscript
NSUserAgent agent;
NSUser thing = agent.CreateDefaultUser();
thing = agent.SaveUser(thing);
```

