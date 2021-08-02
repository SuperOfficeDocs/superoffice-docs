---
uid: crmscript_ref_NSProjectAgent_GetPublishedProjects
title: NSProject[] GetPublishedProjects(Integer[] projectIds)
intellisense: NSProjectAgent.GetPublishedProjects
keywords: NSProjectAgent, GetPublishedProjects
so.topic: reference
---

Get published projects by project ids.

**Parameters:**
 - **projectIds** The array of project ids

**Returns:** NSProject[]

```crmscript
NSProjectAgent agent;
Integer[] projectIds;
NSProject[] res = agent.GetPublishedProjects(projectIds);
```

