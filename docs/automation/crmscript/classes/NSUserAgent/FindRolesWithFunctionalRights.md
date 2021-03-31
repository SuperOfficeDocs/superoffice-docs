---
title: crmscript_ref_NSUserAgent_FindRolesWithFunctionalRights
description: IntegerArray FindRolesWithFunctionalRights(StringArray functionalRightNames)
intellisense: NSUserAgent.FindRolesWithFunctionalRights
keywords: NSUserAgent,FindRolesWithFunctionalRights
so.topic: reference
---

Find all roles with a given set of functional rights. The roles matched must contain one or more of the specified functional rights. 

**Parameters:**
 - **functionalRightNames** An array of functional rights names to search for

**Returns:** Role ids that contains your functional rights

```crmscript
NSUserAgent agent;
StringArray functionalRightNames;
IntegerArray res = agent.FindRolesWithFunctionalRights(functionalRightNames);
```

