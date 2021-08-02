---
uid: crmscript_ref_NSUserAgent_GetAllUserGroups
title: NSUserGroup[] GetAllUserGroups(Bool includeDeleted)
intellisense: NSUserAgent.GetAllUserGroups
keywords: NSUserAgent, GetAllUserGroups
so.topic: reference
---

Get all user groups

**Parameters:**
 - **includeDeleted** Include user groups with Deleted set to true

**Returns:** NSUserGroup[]

```crmscript
NSUserAgent agent;
Bool includeDeleted;
NSUserGroup[] res = agent.GetAllUserGroups(includeDeleted);
```

