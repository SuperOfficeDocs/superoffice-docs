---
title: crmscript_ref_NSEMailAgent_CreateDefaultEMailCustomHeader
description: NSEMailCustomHeader CreateDefaultEMailCustomHeader()
intellisense: NSEMailAgent.CreateDefaultEMailCustomHeader
keywords: NSEMailAgent,CreateDefaultEMailCustomHeader
so.topic: reference
---
	  
Set default values into a new NSEMailCustomHeader.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSEMailCustomHeader with default values.

```crmscript
NSEMailAgent agent;
NSEMailCustomHeader thing = agent.CreateDefaultEMailCustomHeader();
thing = agent.SaveEMailCustomHeader(thing);
```

