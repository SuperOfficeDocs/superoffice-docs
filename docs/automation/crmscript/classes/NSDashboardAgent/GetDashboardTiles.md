---
title: crmscript_ref_NSDashboardAgent_GetDashboardTiles
description: DashboardTileArray GetDashboardTiles(IntegerArray dashboardTileIds)
intellisense: NSDashboardAgent.GetDashboardTiles
keywords: NSDashboardAgent,GetDashboardTiles
so.topic: reference
---

Gets an array of dashboard tiles for the provided ids

**Parameters:**
 - **dashboardTileIds** The ids of the tiles to get

**Returns:** Dashboard tiles

```crmscript
NSDashboardAgent agent;
IntegerArray dashboardTileIds;
DashboardTileArray res = agent.GetDashboardTiles(dashboardTileIds);
```

