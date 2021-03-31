---
title: crmscript_ref_NSProjectAgent_GetProjectList
description: NSProject[] GetProjectList(Integer[]  projectIds);
intellisense: NSProjectAgent.GetProjectList
keywords: NSProjectAgent,GetProjectList
so.topic: reference
---

Gets a vector of Project objects.

**Parameters:**
 - **projectIds** The identifiers of the NSProject objects

**Returns:** Vector of NSProject objects

```crmscript
Integer[] ids;
NSProjectAgent agent;
agent.GetProjectList(ids);
```

