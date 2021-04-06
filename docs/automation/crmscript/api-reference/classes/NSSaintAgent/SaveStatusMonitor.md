---
uid: crmscript_ref_NSSaintAgent_SaveStatusMonitor
title: NSStatusMonitor SaveStatusMonitor(NSStatusMonitor statusMonitor);
intellisense: NSSaintAgent.SaveStatusMonitor
keywords: NSSaintAgent, SaveStatusMonitor
so.topic: reference
---
	  
Updates the existing NSStatusMonitor or creates a new NSStatusMonitor if the id parameter is 0
	  
**Parameters**:
 - **statusMonitor** The NSStatusMonitor to save.

**Returns:** New or updated NSStatusMonitor

```crmscript
NSSaint  agent;
NSStatusMonitor thing = agent.CreateDefaultStatusMonitor();
thing = agent.SaveStatusMonitor(thing);
```

