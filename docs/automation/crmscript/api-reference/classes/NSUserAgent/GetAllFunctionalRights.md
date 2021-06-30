---
uid: crmscript_ref_NSUserAgent_GetAllFunctionalRights
title: SelectableMDOListItem[] GetAllFunctionalRights(Integer roleType)
intellisense: NSUserAgent.GetAllFunctionalRights
keywords: NSUserAgent, GetAllFunctionalRights
so.topic: reference
---

Get a list of all functional rights for the given type of role. MDO List name = 'FunctionRights', extra='roleType=0' 

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
SelectableMDOListItem[] res = agent.GetAllFunctionalRights(roleType);
```

