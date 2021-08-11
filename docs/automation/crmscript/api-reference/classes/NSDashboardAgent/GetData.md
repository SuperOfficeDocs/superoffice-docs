---
uid: crmscript_ref_NSDashboardAgent_GetData
title: NSTileData[] GetData(Integer dashboardTileId, String restrictions)
intellisense: NSDashboardAgent.GetData
keywords: NSDashboardAgent, GetData
so.topic: reference
---

# NSTileData[] GetData(Integer dashboardTileId, String restrictions)

Get data for this tile

**Parameters:**
 - **dashboardTileId** Tile Id
 - **restrictions** Replacement restrictions

**Returns:** NSTileData[]

```crmscript
NSDashboardAgent agent;
Integer dashboardTileId;
String restrictions;
NSTileData[] res = agent.GetData(dashboardTileId, restrictions);
```

