---
uid: crmscript_ref_NSReplicationAgent_CreateDefaultSatellite
title: NSSatellite CreateDefaultSatellite()
intellisense: NSReplicationAgent.CreateDefaultSatellite
keywords: NSReplicationAgent, CreateDefaultSatellite
so.topic: reference
---

# NSSatellite CreateDefaultSatellite()
	  
Set default values into a new NSSatellite.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSSatellite

```crmscript
NSReplicationAgent agent;
NSSatellite thing = agent.CreateDefaultSatellite();
thing = agent.SaveSatellite(thing);
```

