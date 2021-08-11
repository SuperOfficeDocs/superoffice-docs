---
uid: crmscript_ref_NSUserAgent_SaveServiceAuth
title: NSServiceAuth SaveServiceAuth(NSServiceAuth serviceAuth);
intellisense: NSUserAgent.SaveServiceAuth
keywords: NSUserAgent, SaveServiceAuth
so.topic: reference
---

# NSServiceAuth SaveServiceAuth(NSServiceAuth serviceAuth);
	  
Updates the existing NSServiceAuth or creates a new NSServiceAuth if the id parameter is 0
	  
**Parameters**:
 - **serviceAuth** The NSServiceAuth to save.

**Returns:** NSServiceAuth

```crmscript
NSUser  agent;
NSServiceAuth thing = agent.CreateDefaultServiceAuth();
thing = agent.SaveServiceAuth(thing);
```

