---
title: crmscript_ref_NSUserAgent_GetAllRoles
description: SelectableMDOListItemArray GetAllRoles(Integer roleType)
intellisense: NSUserAgent.GetAllRoles
keywords: NSUserAgent,GetAllRoles
so.topic: reference
---

Get a list of all roles for the given type of role. MDO List name = 'Roles', extra='0' (roleType) 

**Parameters:**
 - **roleType** Type of role (Employee/External/Anonymous/System)
     - Enum: 0 = Employee 
     - Enum: 1 = ExternalUser 
     - Enum: 2 = Anonymous 
     - Enum: 3 = System 

**Returns:** FunctionRight items with name and description. Code name for function right is in the extra-info property.

```crmscript
NSUserAgent agent;
Integer roleType;
SelectableMDOListItemArray res = agent.GetAllRoles(roleType);
```

