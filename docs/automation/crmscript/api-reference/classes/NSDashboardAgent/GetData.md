---
uid: crmscript_ref_NSDashboardAgent_GetData
title: TileData[] GetData(Integer dashboardTileId, String restrictions)
intellisense: NSDashboardAgent.GetData
keywords: NSDashboardAgent, GetData
so.topic: reference
---

Get data for this tile

**Parameters:**
 - **dashboardTileId** Tile Id
 - **restrictions** Replacement restrictions

**Returns:** The data

```crmscript
NSDashboardAgent agent;
Integer dashboardTileId;
String restrictions;
TileData[] res = agent.GetData(dashboardTileId, restrictions);
```

