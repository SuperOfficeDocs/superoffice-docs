---
uid: crmscript_ref_NSDashboardAgent_GetDashboardTiles
title: DashboardTile[] GetDashboardTiles(Integer[] dashboardTileIds)
intellisense: NSDashboardAgent.GetDashboardTiles
keywords: NSDashboardAgent, GetDashboardTiles
so.topic: reference
---

Gets an array of dashboard tiles for the provided ids

**Parameters:**
 - **dashboardTileIds** The ids of the tiles to get

**Returns:** Dashboard tiles

```crmscript
NSDashboardAgent agent;
Integer[] dashboardTileIds;
DashboardTile[] res = agent.GetDashboardTiles(dashboardTileIds);
```

