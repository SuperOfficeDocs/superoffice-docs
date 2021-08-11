---
uid: crmscript_ref_NSSaintAgent_SaveStatusMonitorPeriods
title: NSStatusMonitorPeriods SaveStatusMonitorPeriods(NSStatusMonitorPeriods statusMonitorPeriods);
intellisense: NSSaintAgent.SaveStatusMonitorPeriods
keywords: NSSaintAgent, SaveStatusMonitorPeriods
so.topic: reference
---

# NSStatusMonitorPeriods SaveStatusMonitorPeriods(NSStatusMonitorPeriods statusMonitorPeriods);
	  
Updates the existing NSStatusMonitorPeriods or creates a new NSStatusMonitorPeriods if the id parameter is 0
	  
**Parameters**:
 - **statusMonitorPeriods** The NSStatusMonitorPeriods to save.

**Returns:** NSStatusMonitorPeriods

```crmscript
NSSaint  agent;
NSStatusMonitorPeriods thing = agent.CreateDefaultStatusMonitorPeriods();
thing = agent.SaveStatusMonitorPeriods(thing);
```

