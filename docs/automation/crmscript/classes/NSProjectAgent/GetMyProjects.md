---
uid: crmscript_ref_NSProjectAgent_GetMyProjects
title: ProjectArray GetMyProjects(Bool includeMemberProjects)
intellisense: NSProjectAgent.GetMyProjects
keywords: NSProjectAgent, GetMyProjects
so.topic: reference
---

Returning the projects belonging to an associate. If memberProjects is false only the projects where the associate is project responsible is returned, otherwise both the projects where the associate is project responsible and project member is returned.

**Parameters:**
 - **includeMemberProjects** True to include projects where the user is project member.

**Returns:** The list of projects

```crmscript
NSProjectAgent agent;
Bool includeMemberProjects;
ProjectArray res = agent.GetMyProjects(includeMemberProjects);
```

