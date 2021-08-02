---
uid: crmscript_ref_NSUserAgent_GetFunctionalRights
title: NSSelectableMDOListItem[] GetFunctionalRights(Integer roleId)
intellisense: NSUserAgent.GetFunctionalRights
keywords: NSUserAgent, GetFunctionalRights
so.topic: reference
---

Get all functional rights for the given role. Functional rights not set on the role are not included. MDO List name = 'FunctionRights', extra='role=123'

**Parameters:**
 - **roleId** The role id to get the functional rights for.

**Returns:** NSSelectableMDOListItem[]

```crmscript
NSUserAgent agent;
Integer roleId;
NSSelectableMDOListItem[] res = agent.GetFunctionalRights(roleId);
```

