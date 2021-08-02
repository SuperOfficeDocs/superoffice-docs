---
uid: crmscript_ref_NSUserAgent_FindRolesWithFunctionalRights
title: Integer[] FindRolesWithFunctionalRights(String[] functionalRightNames)
intellisense: NSUserAgent.FindRolesWithFunctionalRights
keywords: NSUserAgent, FindRolesWithFunctionalRights
so.topic: reference
---

Find all roles with a given set of functional rights. The roles matched must contain one or more of the specified functional rights. 

**Parameters:**
 - **functionalRightNames** An array of functional rights names to search for

**Returns:** Integer[]

```crmscript
NSUserAgent agent;
String[] functionalRightNames;
Integer[] res = agent.FindRolesWithFunctionalRights(functionalRightNames);
```

