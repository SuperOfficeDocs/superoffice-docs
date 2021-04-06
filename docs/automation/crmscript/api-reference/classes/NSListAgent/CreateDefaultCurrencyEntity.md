---
uid: crmscript_ref_NSListAgent_CreateDefaultCurrencyEntity
title: NSCurrencyEntity CreateDefaultCurrencyEntity()
intellisense: NSListAgent.CreateDefaultCurrencyEntity
keywords: NSListAgent, CreateDefaultCurrencyEntity
so.topic: reference
---
	  
Set default values into a new NSCurrencyEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSCurrencyEntity with default values.

```crmscript
NSListAgent agent;
NSCurrencyEntity thing = agent.CreateDefaultCurrencyEntity();
thing = agent.SaveCurrencyEntity(thing);
```

