---
uid: crmscript_ref_NSEMailAgent_CreateDefaultEMailEntity
title: NSEMailEntity CreateDefaultEMailEntity()
intellisense: NSEMailAgent.CreateDefaultEMailEntity
keywords: NSEMailAgent, CreateDefaultEMailEntity
so.topic: reference
---

# NSEMailEntity CreateDefaultEMailEntity()
	  
Set default values into a new NSEMailEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSEMailEntity

```crmscript
NSEMailAgent agent;
NSEMailEntity thing = agent.CreateDefaultEMailEntity();
thing = agent.SaveEMailEntity(thing);
```

