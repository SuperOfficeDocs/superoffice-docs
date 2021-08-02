---
uid: crmscript_ref_NSDashboardAgent_SaveDashboardTile
title: NSDashboardTile SaveDashboardTile(NSDashboardTile dashboardTile);
intellisense: NSDashboardAgent.SaveDashboardTile
keywords: NSDashboardAgent, SaveDashboardTile
so.topic: reference
---
	  
Updates the existing NSDashboardTile or creates a new NSDashboardTile if the id parameter is 0
	  
**Parameters**:
 - **dashboardTile** The NSDashboardTile to save.

**Returns:** NSDashboardTile

```crmscript
NSDashboard  agent;
NSDashboardTile thing = agent.CreateDefaultDashboardTile();
thing = agent.SaveDashboardTile(thing);
```

