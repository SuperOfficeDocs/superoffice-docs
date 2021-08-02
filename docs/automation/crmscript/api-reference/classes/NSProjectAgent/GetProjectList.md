---
uid: crmscript_ref_NSProjectAgent_GetProjectList
title: NSProject[] GetProjectList(Integer[]  projectIds);
intellisense: NSProjectAgent.GetProjectList
keywords: NSProjectAgent, GetProjectList
so.topic: reference
---

Gets a vector of Project objects.

**Parameters:**
 - **projectIds** The identifiers of the NSProject objects

**Returns:** NSProject[]

```crmscript
Integer[] ids;
NSProjectAgent agent;
NSProject[] res = agent.GetProjectList(ids);
```

