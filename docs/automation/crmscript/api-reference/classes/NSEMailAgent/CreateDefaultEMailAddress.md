---
uid: crmscript_ref_NSEMailAgent_CreateDefaultEMailAddress
title: NSEMailAddress CreateDefaultEMailAddress()
intellisense: NSEMailAgent.CreateDefaultEMailAddress
keywords: NSEMailAgent, CreateDefaultEMailAddress
so.topic: reference
---
	  
Set default values into a new NSEMailAddress.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSEMailAddress

```crmscript
NSEMailAgent agent;
NSEMailAddress thing = agent.CreateDefaultEMailAddress();
thing = agent.SaveEMailAddress(thing);
```

