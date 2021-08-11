---
uid: crmscript_ref_NSPersonAgent_GetColleaguesByDepartment
title: NSPerson[] GetColleaguesByDepartment(Integer departmentId)
intellisense: NSPersonAgent.GetColleaguesByDepartment
keywords: NSPersonAgent, GetColleaguesByDepartment
so.topic: reference
---

# NSPerson[] GetColleaguesByDepartment(Integer departmentId)

Gets the persons working in a specific department in the same company as the logged on user. Departments can be retrieved with the PhoneList.DepartmentList service.

**Parameters:**
 - **departmentId** The department id.

**Returns:** NSPerson[]

```crmscript
NSPersonAgent agent;
Integer departmentId;
NSPerson[] res = agent.GetColleaguesByDepartment(departmentId);
```

