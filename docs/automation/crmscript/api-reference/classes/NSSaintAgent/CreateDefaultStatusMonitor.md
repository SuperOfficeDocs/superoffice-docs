---
uid: crmscript_ref_NSSaintAgent_CreateDefaultStatusMonitor
title: NSStatusMonitor CreateDefaultStatusMonitor()
intellisense: NSSaintAgent.CreateDefaultStatusMonitor
keywords: NSSaintAgent, CreateDefaultStatusMonitor
so.topic: reference
---

# NSStatusMonitor CreateDefaultStatusMonitor()
	  
Set default values into a new NSStatusMonitor.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSStatusMonitor

```crmscript
NSSaintAgent agent;
NSStatusMonitor thing = agent.CreateDefaultStatusMonitor();
thing = agent.SaveStatusMonitor(thing);
```

