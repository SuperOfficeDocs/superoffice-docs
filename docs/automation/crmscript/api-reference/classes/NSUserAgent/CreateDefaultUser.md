---
uid: crmscript_ref_NSUserAgent_CreateDefaultUser
title: NSUser CreateDefaultUser()
intellisense: NSUserAgent.CreateDefaultUser
keywords: NSUserAgent, CreateDefaultUser
so.topic: reference
---

# NSUser CreateDefaultUser()
	  
Set default values into a new NSUser.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSUser

```crmscript
NSUserAgent agent;
NSUser thing = agent.CreateDefaultUser();
thing = agent.SaveUser(thing);
```

