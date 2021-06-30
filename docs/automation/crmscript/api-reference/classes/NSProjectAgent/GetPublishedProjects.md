---
uid: crmscript_ref_NSProjectAgent_GetPublishedProjects
title: Project[] GetPublishedProjects(Integer[] projectIds)
intellisense: NSProjectAgent.GetPublishedProjects
keywords: NSProjectAgent, GetPublishedProjects
so.topic: reference
---

Get published projects by project ids.

**Parameters:**
 - **projectIds** The array of project ids

**Returns:** Projects

```crmscript
NSProjectAgent agent;
Integer[] projectIds;
Project[] res = agent.GetPublishedProjects(projectIds);
```

