---
uid: crmscript_ref_NSEMailAgent_CreateDefaultEMailEnvelope
title: NSEMailEnvelope CreateDefaultEMailEnvelope()
intellisense: NSEMailAgent.CreateDefaultEMailEnvelope
keywords: NSEMailAgent, CreateDefaultEMailEnvelope
so.topic: reference
---
	  
Set default values into a new NSEMailEnvelope.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSEMailEnvelope

```crmscript
NSEMailAgent agent;
NSEMailEnvelope thing = agent.CreateDefaultEMailEnvelope();
thing = agent.SaveEMailEnvelope(thing);
```

