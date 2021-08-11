---
uid: crmscript_ref_NSDashboardAgent_SetTile
title: NSDashboard SetTile(Integer dashboardId, Integer tileId, Integer position)
intellisense: NSDashboardAgent.SetTile
keywords: NSDashboardAgent, SetTile
so.topic: reference
---

# NSDashboard SetTile(Integer dashboardId, Integer tileId, Integer position)

Sets tile in the given dashboard position

**Parameters:**
 - **dashboardId** Dashboard Id
 - **tileId** Tile Id
 - **position** Tile position in the dashboard

**Returns:** The new dashboard is returned after the tile change

```crmscript
NSDashboardAgent agent;
Integer dashboardId;
Integer tileId;
Integer position;
NSDashboard res = agent.SetTile(dashboardId, tileId, position);
```

