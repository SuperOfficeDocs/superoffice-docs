---
uid: crmscript_ref_NSUserAgent_FindRolesWithFunctionalRight
title: NSMDOListItem[] FindRolesWithFunctionalRight(String functionalRightName)
intellisense: NSUserAgent.FindRolesWithFunctionalRight
keywords: NSUserAgent, FindRolesWithFunctionalRight
so.topic: reference
---

Find all roles with a given functional right. The roles matched must contain the specified functional right. 

**Parameters:**
 - **functionalRightName** Functional right name to search for

**Returns:** NSMDOListItem[]

```crmscript
NSUserAgent agent;
String functionalRightName;
NSMDOListItem[] res = agent.FindRolesWithFunctionalRight(functionalRightName);
```

