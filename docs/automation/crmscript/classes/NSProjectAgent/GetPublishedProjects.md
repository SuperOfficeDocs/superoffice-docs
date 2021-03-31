---
title: crmscript_ref_NSProjectAgent_GetPublishedProjects
description: ProjectArray GetPublishedProjects(IntegerArray projectIds)
intellisense: NSProjectAgent.GetPublishedProjects
keywords: NSProjectAgent,GetPublishedProjects
so.topic: reference
---

Get published projects by project ids.

**Parameters:**
 - **projectIds** The array of project ids

**Returns:** Projects

```crmscript
NSProjectAgent agent;
IntegerArray projectIds;
ProjectArray res = agent.GetPublishedProjects(projectIds);
```

