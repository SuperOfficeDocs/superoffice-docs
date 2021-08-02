---
uid: crmscript_ref_NSListAgent_GetProjectTypeList
title: NSProjectType[] GetProjectTypeList(Integer[]  projectTypeIds);
intellisense: NSListAgent.GetProjectTypeList
keywords: NSListAgent, GetProjectTypeList
so.topic: reference
---

Gets a vector of NSProjectType objects.

**Parameters:**
 - **projectTypeIds** The identifiers of the NSProjectType objects

**Returns:** NSProjectType[]

```crmscript
Integer[] ids;
NSListAgent agent;
NSProjectType[] res = agent.GetProjectTypeList(ids);
```

