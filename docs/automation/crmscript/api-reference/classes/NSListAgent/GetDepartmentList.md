---
uid: crmscript_ref_NSListAgent_GetDepartmentList
title: NSDepartment[] GetDepartmentList(Integer[]  departmentIds);
intellisense: NSListAgent.GetDepartmentList
keywords: NSListAgent, GetDepartmentList
so.topic: reference
---

Gets a vector of Department objects.

**Parameters:**
 - **departmentIds** The identifiers of the NSDepartment objects

**Returns:** NSDepartment[]

```crmscript
Integer[] ids;
NSListAgent agent;
NSDepartment[] res = agent.GetDepartmentList(ids);
```

