---
uid: crmscript_ref_NSDashboardAgent_GetDashboards
title: NSDashboard[] GetDashboards(Integer associateId)
intellisense: NSDashboardAgent.GetDashboards
keywords: NSDashboardAgent, GetDashboards
so.topic: reference
---

# NSDashboard[] GetDashboards(Integer associateId)

Gets all dashboards for an associate

**Parameters:**
 - **associateId** Associate Id

**Returns:** NSDashboard[]

```crmscript
NSDashboardAgent agent;
Integer associateId;
NSDashboard[] res = agent.GetDashboards(associateId);
```

