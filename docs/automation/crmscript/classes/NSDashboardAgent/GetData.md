---
title: crmscript_ref_NSDashboardAgent_GetData
description: TileDataArray GetData(Integer dashboardTileId, String restrictions)
intellisense: NSDashboardAgent.GetData
keywords: NSDashboardAgent,GetData
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
TileDataArray res = agent.GetData(dashboardTileId, restrictions);
```

