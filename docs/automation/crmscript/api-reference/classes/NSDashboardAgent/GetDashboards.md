---
uid: crmscript_ref_NSDashboardAgent_GetDashboards
title: Dashboard[] GetDashboards(Integer associateId)
intellisense: NSDashboardAgent.GetDashboards
keywords: NSDashboardAgent, GetDashboards
so.topic: reference
---

Gets all dashboards for an associate

**Parameters:**
 - **associateId** Associate Id

**Returns:** All the users dashboards

```crmscript
NSDashboardAgent agent;
Integer associateId;
Dashboard[] res = agent.GetDashboards(associateId);
```

