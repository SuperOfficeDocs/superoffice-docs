---
uid: crmscript_ref_NSSaleAgent_CreateDefaultSaleEntity
title: NSSaleEntity CreateDefaultSaleEntity()
intellisense: NSSaleAgent.CreateDefaultSaleEntity
keywords: NSSaleAgent, CreateDefaultSaleEntity
so.topic: reference
---
	  
Set default values into a new NSSaleEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSSaleEntity

```crmscript
NSSaleAgent agent;
NSSaleEntity thing = agent.CreateDefaultSaleEntity();
thing = agent.SaveSaleEntity(thing);
```

