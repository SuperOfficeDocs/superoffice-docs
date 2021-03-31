---
title: crmscript_ref_NSDashboardAgent_CreateDefaultDashboardTile
description: NSDashboardTile CreateDefaultDashboardTile()
intellisense: NSDashboardAgent.CreateDefaultDashboardTile
keywords: NSDashboardAgent,CreateDefaultDashboardTile
so.topic: reference
---
	  
Set default values into a new NSDashboardTile.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSDashboardTile with default values.

```crmscript
NSDashboardAgent agent;
NSDashboardTile thing = agent.CreateDefaultDashboardTile();
thing = agent.SaveDashboardTile(thing);
```

