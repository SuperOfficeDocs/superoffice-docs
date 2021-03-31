---
title: crmscript_ref_NSListAgent_GetProjectStatusList
description: NSProjectStatus[] GetProjectStatusList(Integer[]  projectStatusIds);
intellisense: NSListAgent.GetProjectStatusList
keywords: NSListAgent,GetProjectStatusList
so.topic: reference
---

Gets a vector of ProjectStatus objects.

**Parameters:**
 - **projectStatusIds** The identifiers of the NSProjectStatus objects

**Returns:** Vector of NSProjectStatus objects

```crmscript
Integer[] ids;
NSListAgent agent;
agent.GetProjectStatusList(ids);
```

