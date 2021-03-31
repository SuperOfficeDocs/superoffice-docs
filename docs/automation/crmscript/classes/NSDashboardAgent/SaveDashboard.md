---
title: crmscript_ref_NSDashboardAgent_SaveDashboard
description: NSDashboard SaveDashboard(NSDashboard dashboard);
intellisense: NSDashboardAgent.SaveDashboard
keywords: NSDashboardAgent,SaveDashboard
so.topic: reference
---
	  
Updates the existing NSDashboard or creates a new NSDashboard if the id parameter is 0
	  
**Parameters**:
 - **dashboard** The NSDashboard to save.

**Returns:** New or updated NSDashboard

```crmscript
NSDashboard  agent;
NSDashboard thing = agent.CreateDefaultDashboard();
thing = agent.SaveDashboard(thing);
```

