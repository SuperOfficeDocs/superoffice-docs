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

**Returns:** Vector of NSDepartment objects

```crmscript
Integer[] ids;
NSListAgent agent;
agent.GetDepartmentList(ids);
```

