---
uid: crmscript_ref_NSProjectAgent_GetProjectMembers
title: NSProjectMember[] GetProjectMembers(Integer projectId)
intellisense: NSProjectAgent.GetProjectMembers
keywords: NSProjectAgent, GetProjectMembers
so.topic: reference
---

Returns an array of project members

**Parameters:**
 - **projectId** The project id

**Returns:** NSProjectMember[]

```crmscript
NSProjectAgent agent;
Integer projectId;
NSProjectMember[] res = agent.GetProjectMembers(projectId);
```

