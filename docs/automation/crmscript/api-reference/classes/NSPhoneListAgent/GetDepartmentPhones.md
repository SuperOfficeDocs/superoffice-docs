---
uid: crmscript_ref_NSPhoneListAgent_GetDepartmentPhones
title: NSPhoneListItem[] GetDepartmentPhones(Integer departmentId)
intellisense: NSPhoneListAgent.GetDepartmentPhones
keywords: NSPhoneListAgent, GetDepartmentPhones
so.topic: reference
---

# NSPhoneListItem[] GetDepartmentPhones(Integer departmentId)

Returns an array of phone list items with the in-parameter as restriction. The in-parameter must be a valid department id (UserGroupId).

**Parameters:**
 - **departmentId** The department to get the phone list for

**Returns:** NSPhoneListItem[]

```crmscript
NSPhoneListAgent agent;
Integer departmentId;
NSPhoneListItem[] res = agent.GetDepartmentPhones(departmentId);
```

