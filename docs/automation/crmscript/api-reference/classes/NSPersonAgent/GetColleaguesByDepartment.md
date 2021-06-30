---
uid: crmscript_ref_NSPersonAgent_GetColleaguesByDepartment
title: Person[] GetColleaguesByDepartment(Integer departmentId)
intellisense: NSPersonAgent.GetColleaguesByDepartment
keywords: NSPersonAgent, GetColleaguesByDepartment
so.topic: reference
---

Gets the persons working in a specific department in the same company as the logged on user. Departments can be retrieved with the PhoneList.DepartmentList service.

**Parameters:**
 - **departmentId** The department id.

**Returns:** PersonList with colleagues.

```crmscript
NSPersonAgent agent;
Integer departmentId;
Person[] res = agent.GetColleaguesByDepartment(departmentId);
```

