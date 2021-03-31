---
title: crmscript_ref_NSUserAgent_CreateDefaultUntrustedCredentials
description: NSUntrustedCredentials CreateDefaultUntrustedCredentials()
intellisense: NSUserAgent.CreateDefaultUntrustedCredentials
keywords: NSUserAgent,CreateDefaultUntrustedCredentials
so.topic: reference
---
	  
Set default values into a new NSUntrustedCredentials.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSUntrustedCredentials with default values.

```crmscript
NSUserAgent agent;
NSUntrustedCredentials thing = agent.CreateDefaultUntrustedCredentials();
thing = agent.SaveUntrustedCredentials(thing);
```

