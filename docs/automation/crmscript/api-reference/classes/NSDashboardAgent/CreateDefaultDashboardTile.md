---
uid: crmscript_ref_NSDashboardAgent_CreateDefaultDashboardTile
title: NSDashboardTile CreateDefaultDashboardTile()
intellisense: NSDashboardAgent.CreateDefaultDashboardTile
keywords: NSDashboardAgent, CreateDefaultDashboardTile
so.topic: reference
---

# NSDashboardTile CreateDefaultDashboardTile()
	  
Set default values into a new NSDashboardTile.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSDashboardTile

```crmscript
NSDashboardAgent agent;
NSDashboardTile thing = agent.CreateDefaultDashboardTile();
thing = agent.SaveDashboardTile(thing);
```

