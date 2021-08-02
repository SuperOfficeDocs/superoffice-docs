---
uid: crmscript_ref_NSDashboardAgent_GetDashboardTiles
title: NSDashboardTile[] GetDashboardTiles(Integer[] dashboardTileIds)
intellisense: NSDashboardAgent.GetDashboardTiles
keywords: NSDashboardAgent, GetDashboardTiles
so.topic: reference
---

Gets an array of dashboard tiles for the provided ids

**Parameters:**
 - **dashboardTileIds** The ids of the tiles to get

**Returns:** NSDashboardTile[]

```crmscript
NSDashboardAgent agent;
Integer[] dashboardTileIds;
NSDashboardTile[] res = agent.GetDashboardTiles(dashboardTileIds);
```

