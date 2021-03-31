---
title: crmscript_ref_NSListAgent_GetProjectTypeList
description: NSProjectType[] GetProjectTypeList(Integer[]  projectTypeIds);
intellisense: NSListAgent.GetProjectTypeList
keywords: NSListAgent,GetProjectTypeList
so.topic: reference
---

Gets a vector of ProjectType objects.

**Parameters:**
 - **projectTypeIds** The identifiers of the NSProjectType objects

**Returns:** Vector of NSProjectType objects

```crmscript
Integer[] ids;
NSListAgent agent;
agent.GetProjectTypeList(ids);
```

