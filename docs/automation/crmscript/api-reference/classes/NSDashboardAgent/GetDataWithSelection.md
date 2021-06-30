---
uid: crmscript_ref_NSDashboardAgent_GetDataWithSelection
title: TileData[] GetDataWithSelection(Integer dashboardTileId, Integer selectionId, String restrictions)
intellisense: NSDashboardAgent.GetDataWithSelection
keywords: NSDashboardAgent, GetDataWithSelection
so.topic: reference
---

Get data for this tile

**Parameters:**
 - **dashboardTileId** Tile Id
 - **selectionId** Selection Id
 - **restrictions** Replacement restrictions

**Returns:** The data

```crmscript
NSDashboardAgent agent;
Integer dashboardTileId;
Integer selectionId;
String restrictions;
TileData[] res = agent.GetDataWithSelection(dashboardTileId, selectionId, restrictions);
```

