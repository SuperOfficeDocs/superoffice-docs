---
uid: crmscript_ref_NSUserAgent_SaveUser
title: NSUser SaveUser(NSUser user);
intellisense: NSUserAgent.SaveUser
keywords: NSUserAgent, SaveUser
so.topic: reference
---
	  
Updates the existing NSUser or creates a new NSUser if the id parameter is 0
	  
**Parameters**:
 - **user** The NSUser to save.

**Returns:** NSUser

```crmscript
NSUser  agent;
NSUser thing = agent.CreateDefaultUser();
thing = agent.SaveUser(thing);
```

