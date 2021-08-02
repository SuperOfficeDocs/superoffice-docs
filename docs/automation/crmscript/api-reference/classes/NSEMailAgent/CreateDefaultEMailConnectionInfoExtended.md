---
uid: crmscript_ref_NSEMailAgent_CreateDefaultEMailConnectionInfoExtended
title: NSEMailConnectionInfoExtended CreateDefaultEMailConnectionInfoExtended()
intellisense: NSEMailAgent.CreateDefaultEMailConnectionInfoExtended
keywords: NSEMailAgent, CreateDefaultEMailConnectionInfoExtended
so.topic: reference
---
	  
Set default values into a new NSEMailConnectionInfoExtended.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSEMailConnectionInfoExtended

```crmscript
NSEMailAgent agent;
NSEMailConnectionInfoExtended thing = agent.CreateDefaultEMailConnectionInfoExtended();
thing = agent.SaveEMailConnectionInfoExtended(thing);
```

