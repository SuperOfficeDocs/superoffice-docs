---
title: crmscript_ref_NSProjectAgent_GetProjectEventEntityFromProjectId
description: ProjectEventEntity GetProjectEventEntityFromProjectId(Integer projectId)
intellisense: NSProjectAgent.GetProjectEventEntityFromProjectId
keywords: NSProjectAgent,GetProjectEventEntityFromProjectId
so.topic: reference
---

Get a ProjectEventEntity based on a projectId.

**Parameters:**
 - **projectId** The projectId to get a ProjectEventEntity for

**Returns:** ProjectEventEntity

```crmscript
NSProjectAgent agent;
Integer projectId;
ProjectEventEntity res = agent.GetProjectEventEntityFromProjectId(projectId);
```

