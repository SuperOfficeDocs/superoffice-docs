---
uid: crmscript_ref_NSUserAgent_CreateDefaultUntrustedCredentials
title: NSUntrustedCredentials CreateDefaultUntrustedCredentials()
intellisense: NSUserAgent.CreateDefaultUntrustedCredentials
keywords: NSUserAgent, CreateDefaultUntrustedCredentials
so.topic: reference
---

# NSUntrustedCredentials CreateDefaultUntrustedCredentials()
	  
Set default values into a new NSUntrustedCredentials.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSUntrustedCredentials

```crmscript
NSUserAgent agent;
NSUntrustedCredentials thing = agent.CreateDefaultUntrustedCredentials();
thing = agent.SaveUntrustedCredentials(thing);
```

