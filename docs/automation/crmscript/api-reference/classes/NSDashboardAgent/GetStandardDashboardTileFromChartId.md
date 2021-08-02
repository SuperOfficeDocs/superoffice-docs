---
uid: crmscript_ref_NSDashboardAgent_GetStandardDashboardTileFromChartId
title: NSDashboardTile GetStandardDashboardTileFromChartId(String chartId)
intellisense: NSDashboardAgent.GetStandardDashboardTileFromChartId
keywords: NSDashboardAgent, GetStandardDashboardTileFromChartId
so.topic: reference
---

Gets the standard tile (not personal tile) corresponding to the given chart id

**Parameters:**
 - **chartId** The ChartId of the wanted chart/tile

**Returns:** NSDashboardTile

```crmscript
NSDashboardAgent agent;
String chartId;
NSDashboardTile res = agent.GetStandardDashboardTileFromChartId(chartId);
```

