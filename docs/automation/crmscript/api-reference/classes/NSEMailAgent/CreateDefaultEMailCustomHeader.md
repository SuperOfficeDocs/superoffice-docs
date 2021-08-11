---
uid: crmscript_ref_NSEMailAgent_CreateDefaultEMailCustomHeader
title: NSEMailCustomHeader CreateDefaultEMailCustomHeader()
intellisense: NSEMailAgent.CreateDefaultEMailCustomHeader
keywords: NSEMailAgent, CreateDefaultEMailCustomHeader
so.topic: reference
---

# NSEMailCustomHeader CreateDefaultEMailCustomHeader()
	  
Set default values into a new NSEMailCustomHeader.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSEMailCustomHeader

```crmscript
NSEMailAgent agent;
NSEMailCustomHeader thing = agent.CreateDefaultEMailCustomHeader();
thing = agent.SaveEMailCustomHeader(thing);
```

