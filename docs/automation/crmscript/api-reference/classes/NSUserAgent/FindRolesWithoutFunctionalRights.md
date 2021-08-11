---
uid: crmscript_ref_NSUserAgent_FindRolesWithoutFunctionalRights
title: Integer[] FindRolesWithoutFunctionalRights(String[] functionalRightNames)
intellisense: NSUserAgent.FindRolesWithoutFunctionalRights
keywords: NSUserAgent, FindRolesWithoutFunctionalRights
so.topic: reference
---

# Integer[] FindRolesWithoutFunctionalRights(String[] functionalRightNames)

Find all roles without a given set of functional rights. The roles matched must not contain any of the specified functional rights. 

**Parameters:**
 - **functionalRightNames** An array of functional rights names to search for

**Returns:** Integer[]

```crmscript
NSUserAgent agent;
String[] functionalRightNames;
Integer[] res = agent.FindRolesWithoutFunctionalRights(functionalRightNames);
```

