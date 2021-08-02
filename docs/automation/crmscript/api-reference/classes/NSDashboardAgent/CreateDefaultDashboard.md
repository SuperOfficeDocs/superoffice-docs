---
uid: crmscript_ref_NSDashboardAgent_CreateDefaultDashboard
title: NSDashboard CreateDefaultDashboard()
intellisense: NSDashboardAgent.CreateDefaultDashboard
keywords: NSDashboardAgent, CreateDefaultDashboard
so.topic: reference
---
	  
Set default values into a new NSDashboard.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSDashboard

```crmscript
NSDashboardAgent agent;
NSDashboard thing = agent.CreateDefaultDashboard();
thing = agent.SaveDashboard(thing);
```

