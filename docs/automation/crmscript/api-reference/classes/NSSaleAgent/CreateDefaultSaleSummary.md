---
uid: crmscript_ref_NSSaleAgent_CreateDefaultSaleSummary
title: NSSaleSummary CreateDefaultSaleSummary()
intellisense: NSSaleAgent.CreateDefaultSaleSummary
keywords: NSSaleAgent, CreateDefaultSaleSummary
so.topic: reference
---

# NSSaleSummary CreateDefaultSaleSummary()
	  
Set default values into a new NSSaleSummary.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSSaleSummary

```crmscript
NSSaleAgent agent;
NSSaleSummary thing = agent.CreateDefaultSaleSummary();
thing = agent.SaveSaleSummary(thing);
```

