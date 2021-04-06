---
uid: crmscript_ref_NSEMailAgent_CreateDefaultEMailEntity
title: NSEMailEntity CreateDefaultEMailEntity()
intellisense: NSEMailAgent.CreateDefaultEMailEntity
keywords: NSEMailAgent, CreateDefaultEMailEntity
so.topic: reference
---
	  
Set default values into a new NSEMailEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSEMailEntity with default values.

```crmscript
NSEMailAgent agent;
NSEMailEntity thing = agent.CreateDefaultEMailEntity();
thing = agent.SaveEMailEntity(thing);
```

