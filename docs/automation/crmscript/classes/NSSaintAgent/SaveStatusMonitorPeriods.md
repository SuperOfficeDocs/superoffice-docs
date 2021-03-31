---
title: crmscript_ref_NSSaintAgent_SaveStatusMonitorPeriods
description: NSStatusMonitorPeriods SaveStatusMonitorPeriods(NSStatusMonitorPeriods statusMonitorPeriods);
intellisense: NSSaintAgent.SaveStatusMonitorPeriods
keywords: NSSaintAgent,SaveStatusMonitorPeriods
so.topic: reference
---
	  
Updates the existing NSStatusMonitorPeriods or creates a new NSStatusMonitorPeriods if the id parameter is 0
	  
**Parameters**:
 - **statusMonitorPeriods** The NSStatusMonitorPeriods to save.

**Returns:** New or updated NSStatusMonitorPeriods

```crmscript
NSSaint  agent;
NSStatusMonitorPeriods thing = agent.CreateDefaultStatusMonitorPeriods();
thing = agent.SaveStatusMonitorPeriods(thing);
```

