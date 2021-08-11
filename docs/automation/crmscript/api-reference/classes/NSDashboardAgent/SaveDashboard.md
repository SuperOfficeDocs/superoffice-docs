---
uid: crmscript_ref_NSDashboardAgent_SaveDashboard
title: NSDashboard SaveDashboard(NSDashboard dashboard);
intellisense: NSDashboardAgent.SaveDashboard
keywords: NSDashboardAgent, SaveDashboard
so.topic: reference
---

# NSDashboard SaveDashboard(NSDashboard dashboard);
	  
Updates the existing NSDashboard or creates a new NSDashboard if the id parameter is 0
	  
**Parameters**:
 - **dashboard** The NSDashboard to save.

**Returns:** NSDashboard

```crmscript
NSDashboard  agent;
NSDashboard thing = agent.CreateDefaultDashboard();
thing = agent.SaveDashboard(thing);
```

