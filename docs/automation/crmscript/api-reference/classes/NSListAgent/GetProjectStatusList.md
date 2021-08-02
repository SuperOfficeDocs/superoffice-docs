---
uid: crmscript_ref_NSListAgent_GetProjectStatusList
title: NSProjectStatus[] GetProjectStatusList(Integer[]  projectStatusIds);
intellisense: NSListAgent.GetProjectStatusList
keywords: NSListAgent, GetProjectStatusList
so.topic: reference
---

Gets a vector of NSProjectStatus objects.

**Parameters:**
 - **projectStatusIds** The identifiers of the NSProjectStatus objects

**Returns:** NSProjectStatus[]

```crmscript
Integer[] ids;
NSListAgent agent;
NSProjectStatus[] res = agent.GetProjectStatusList(ids);
```

