---
uid: crmscript_ref_NSMarketingAgent_CreateDefaultFormEntity
title: NSFormEntity CreateDefaultFormEntity()
intellisense: NSMarketingAgent.CreateDefaultFormEntity
keywords: NSMarketingAgent, CreateDefaultFormEntity
so.topic: reference
---
	  
Set default values into a new NSFormEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSFormEntity with default values.

```crmscript
NSMarketingAgent agent;
NSFormEntity thing = agent.CreateDefaultFormEntity();
thing = agent.SaveFormEntity(thing);
```

