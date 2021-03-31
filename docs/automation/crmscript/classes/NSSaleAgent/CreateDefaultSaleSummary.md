---
title: crmscript_ref_NSSaleAgent_CreateDefaultSaleSummary
description: NSSaleSummary CreateDefaultSaleSummary()
intellisense: NSSaleAgent.CreateDefaultSaleSummary
keywords: NSSaleAgent,CreateDefaultSaleSummary
so.topic: reference
---
	  
Set default values into a new NSSaleSummary.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSSaleSummary with default values.

```crmscript
NSSaleAgent agent;
NSSaleSummary thing = agent.CreateDefaultSaleSummary();
thing = agent.SaveSaleSummary(thing);
```

