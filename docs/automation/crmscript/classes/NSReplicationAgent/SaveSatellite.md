---
title: crmscript_ref_NSReplicationAgent_SaveSatellite
description: NSSatellite SaveSatellite(NSSatellite satellite);
intellisense: NSReplicationAgent.SaveSatellite
keywords: NSReplicationAgent,SaveSatellite
so.topic: reference
---
	  
Updates the existing NSSatellite or creates a new NSSatellite if the id parameter is 0
	  
**Parameters**:
 - **satellite** The NSSatellite to save.

**Returns:** New or updated NSSatellite

```crmscript
NSReplication  agent;
NSSatellite thing = agent.CreateDefaultSatellite();
thing = agent.SaveSatellite(thing);
```

