---
uid: crmscript_ref_NSUserAgent_GetAllRoles
title: NSSelectableMDOListItem[] GetAllRoles(Integer roleType)
intellisense: NSUserAgent.GetAllRoles
keywords: NSUserAgent, GetAllRoles
so.topic: reference
---

# NSSelectableMDOListItem[] GetAllRoles(Integer roleType)

Get a list of all roles for the given type of role. MDO List name = 'Roles', extra='0' (roleType) 

**Parameters:**
 - **roleType** Type of role (Employee/External/Anonymous/System)
     - Enum: 0 = Employee 
     - Enum: 1 = ExternalUser 
     - Enum: 2 = Anonymous 
     - Enum: 3 = System 

**Returns:** NSSelectableMDOListItem[]

```crmscript
NSUserAgent agent;
Integer roleType;
NSSelectableMDOListItem[] res = agent.GetAllRoles(roleType);
```

