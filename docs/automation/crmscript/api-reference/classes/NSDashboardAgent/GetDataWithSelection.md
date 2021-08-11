---
uid: crmscript_ref_NSDashboardAgent_GetDataWithSelection
title: NSTileData[] GetDataWithSelection(Integer dashboardTileId, Integer selectionId, String restrictions)
intellisense: NSDashboardAgent.GetDataWithSelection
keywords: NSDashboardAgent, GetDataWithSelection
so.topic: reference
---

# NSTileData[] GetDataWithSelection(Integer dashboardTileId, Integer selectionId, String restrictions)

Get data for this tile

**Parameters:**
 - **dashboardTileId** Tile Id
 - **selectionId** Selection Id
 - **restrictions** Replacement restrictions

**Returns:** NSTileData[]

```crmscript
NSDashboardAgent agent;
Integer dashboardTileId;
Integer selectionId;
String restrictions;
NSTileData[] res = agent.GetDataWithSelection(dashboardTileId, selectionId, restrictions);
```

