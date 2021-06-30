---
uid: crmscript_ref_NSProjectAgent_GetProjectMembers
title: ProjectMember[] GetProjectMembers(Integer projectId)
intellisense: NSProjectAgent.GetProjectMembers
keywords: NSProjectAgent, GetProjectMembers
so.topic: reference
---

Returns an array of project members

**Parameters:**
 - **projectId** The project id

**Returns:** An array of project members

```crmscript
NSProjectAgent agent;
Integer projectId;
ProjectMember[] res = agent.GetProjectMembers(projectId);
```

