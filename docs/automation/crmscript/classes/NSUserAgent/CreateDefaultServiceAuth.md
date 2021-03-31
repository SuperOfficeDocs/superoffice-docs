---
title: crmscript_ref_NSUserAgent_CreateDefaultServiceAuth
description: NSServiceAuth CreateDefaultServiceAuth()
intellisense: NSUserAgent.CreateDefaultServiceAuth
keywords: NSUserAgent,CreateDefaultServiceAuth
so.topic: reference
---
	  
Set default values into a new NSServiceAuth.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSServiceAuth with default values.

```crmscript
NSUserAgent agent;
NSServiceAuth thing = agent.CreateDefaultServiceAuth();
thing = agent.SaveServiceAuth(thing);
```

