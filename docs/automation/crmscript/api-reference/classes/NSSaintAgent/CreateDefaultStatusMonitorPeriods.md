---
uid: crmscript_ref_NSSaintAgent_CreateDefaultStatusMonitorPeriods
title: NSStatusMonitorPeriods CreateDefaultStatusMonitorPeriods()
intellisense: NSSaintAgent.CreateDefaultStatusMonitorPeriods
keywords: NSSaintAgent, CreateDefaultStatusMonitorPeriods
so.topic: reference
---
	  
Set default values into a new NSStatusMonitorPeriods.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSStatusMonitorPeriods

```crmscript
NSSaintAgent agent;
NSStatusMonitorPeriods thing = agent.CreateDefaultStatusMonitorPeriods();
thing = agent.SaveStatusMonitorPeriods(thing);
```

