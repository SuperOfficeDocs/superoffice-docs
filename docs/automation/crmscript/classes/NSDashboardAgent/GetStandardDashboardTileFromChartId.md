---
title: crmscript_ref_NSDashboardAgent_GetStandardDashboardTileFromChartId
description: DashboardTile GetStandardDashboardTileFromChartId(String chartId)
intellisense: NSDashboardAgent.GetStandardDashboardTileFromChartId
keywords: NSDashboardAgent,GetStandardDashboardTileFromChartId
so.topic: reference
---

Gets the standard tile (not personal tile) corresponding to the given chart id

**Parameters:**
 - **chartId** The ChartId of the wanted chart/tile

**Returns:** Standard tile

```crmscript
NSDashboardAgent agent;
String chartId;
DashboardTile res = agent.GetStandardDashboardTileFromChartId(chartId);
```

