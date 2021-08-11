---
uid: crmscript_ref_NSUserAgent_GetAllFunctionalRights
title: NSSelectableMDOListItem[] GetAllFunctionalRights(Integer roleType)
intellisense: NSUserAgent.GetAllFunctionalRights
keywords: NSUserAgent, GetAllFunctionalRights
so.topic: reference
---

# NSSelectableMDOListItem[] GetAllFunctionalRights(Integer roleType)

Get a list of all functional rights for the given type of role. MDO List name = 'FunctionRights', extra='roleType=0' 

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
NSSelectableMDOListItem[] res = agent.GetAllFunctionalRights(roleType);
```

