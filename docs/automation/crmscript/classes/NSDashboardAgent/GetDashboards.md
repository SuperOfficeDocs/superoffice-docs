---
title: crmscript_ref_NSDashboardAgent_GetDashboards
description: DashboardArray GetDashboards(Integer associateId)
intellisense: NSDashboardAgent.GetDashboards
keywords: NSDashboardAgent,GetDashboards
so.topic: reference
---

Gets all dashboards for an associate

**Parameters:**
 - **associateId** Associate Id

**Returns:** All the users dashboards

```crmscript
NSDashboardAgent agent;
Integer associateId;
DashboardArray res = agent.GetDashboards(associateId);
```

