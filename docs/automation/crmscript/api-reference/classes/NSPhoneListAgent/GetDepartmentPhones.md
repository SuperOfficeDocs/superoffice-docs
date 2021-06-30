---
uid: crmscript_ref_NSPhoneListAgent_GetDepartmentPhones
title: PhoneListItem[] GetDepartmentPhones(Integer departmentId)
intellisense: NSPhoneListAgent.GetDepartmentPhones
keywords: NSPhoneListAgent, GetDepartmentPhones
so.topic: reference
---

Returns an array of phone list items with the in-parameter as restriction. The in-parameter must be a valid department id (UserGroupId).

**Parameters:**
 - **departmentId** The department to get the phone list for

**Returns:** The department phone list

```crmscript
NSPhoneListAgent agent;
Integer departmentId;
PhoneListItem[] res = agent.GetDepartmentPhones(departmentId);
```

