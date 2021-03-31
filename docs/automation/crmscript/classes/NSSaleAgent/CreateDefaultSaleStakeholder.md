---
uid: crmscript_ref_NSSaleAgent_CreateDefaultSaleStakeholder
title: NSSaleStakeholder CreateDefaultSaleStakeholder()
intellisense: NSSaleAgent.CreateDefaultSaleStakeholder
keywords: NSSaleAgent, CreateDefaultSaleStakeholder
so.topic: reference
---
	  
Set default values into a new NSSaleStakeholder.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSSaleStakeholder with default values.

```crmscript
NSSaleAgent agent;
NSSaleStakeholder thing = agent.CreateDefaultSaleStakeholder();
thing = agent.SaveSaleStakeholder(thing);
```

