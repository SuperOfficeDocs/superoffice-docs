---
uid: crmscript_ref_NSEMailAgent_CreateDefaultEMailAttachment
title: NSEMailAttachment CreateDefaultEMailAttachment()
intellisense: NSEMailAgent.CreateDefaultEMailAttachment
keywords: NSEMailAgent, CreateDefaultEMailAttachment
so.topic: reference
---
	  
Set default values into a new NSEMailAttachment.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSEMailAttachment with default values.

```crmscript
NSEMailAgent agent;
NSEMailAttachment thing = agent.CreateDefaultEMailAttachment();
thing = agent.SaveEMailAttachment(thing);
```

