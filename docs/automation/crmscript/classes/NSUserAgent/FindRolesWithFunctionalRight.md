---
title: crmscript_ref_NSUserAgent_FindRolesWithFunctionalRight
description: MDOListItemArray FindRolesWithFunctionalRight(String functionalRightName)
intellisense: NSUserAgent.FindRolesWithFunctionalRight
keywords: NSUserAgent,FindRolesWithFunctionalRight
so.topic: reference
---

Find all roles with a given functional right. The roles matched must contain the specified functional right. 

**Parameters:**
 - **functionalRightName** Functional right name to search for

**Returns:** Roles that contains the given functional right

```crmscript
NSUserAgent agent;
String functionalRightName;
MDOListItemArray res = agent.FindRolesWithFunctionalRight(functionalRightName);
```

