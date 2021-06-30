---
uid: crmscript_ref_NSUserAgent_GetFunctionalRights
title: SelectableMDOListItem[] GetFunctionalRights(Integer roleId)
intellisense: NSUserAgent.GetFunctionalRights
keywords: NSUserAgent, GetFunctionalRights
so.topic: reference
---

Get all functional rights for the given role. Functional rights not set on the role are not included. MDO List name = 'FunctionRights', extra='role=123'

**Parameters:**
 - **roleId** The role id to get the functional rights for.

**Returns:** FunctionRight items with name and description. Code name for function right is in the extra-info property.

```crmscript
NSUserAgent agent;
Integer roleId;
SelectableMDOListItem[] res = agent.GetFunctionalRights(roleId);
```

