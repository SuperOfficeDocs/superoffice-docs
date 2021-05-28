---
uid: crmscript_class_nsreplicationagent_savesatellite
title: NSSatellite SaveSatellite()
description: CRMScript method in the NSReplicationAgent class that creates or updates a satellite
intellisense: NSReplicationAgent.SaveSatellite
keywords: NSReplicationAgent, SaveSatellite, SaveSatellite(NSSatellite)
so.topic: reference
---

# SaveSatellite()

Updates the existing NSSatellite or creates a new NSSatellite if the ID parameter is 0.

Returns the new or updated NSSatellite.

`NSSatellite SaveSatellite(NSSatellite satellite)`

## Parameters

| Parameter | Type | Description |
|---|---|---|
| satellite | NSSatellite | The object to save. |

## Examples

```crmscript
NSReplication  agent;
NSSatellite thing = agent.CreateDefaultSatellite();
thing = agent.SaveSatellite(thing);
```
