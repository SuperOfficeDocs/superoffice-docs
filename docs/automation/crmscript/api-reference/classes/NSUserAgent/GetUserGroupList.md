---
uid: crmscript_ref_NSUserAgent_GetUserGroupList
title: NSUserGroup[] GetUserGroupList(Integer[]  userGroupIds);
intellisense: NSUserAgent.GetUserGroupList
keywords: NSUserAgent, GetUserGroupList
so.topic: reference
---

# NSUserGroup[] GetUserGroupList(Integer[]  userGroupIds);

Gets a vector of UserGroup objects.

**Parameters:**
 - **userGroupIds** The identifiers of the NSUserGroup objects

**Returns:** NSUserGroup[]

```crmscript
Integer[] ids;
NSUserAgent agent;
agent.GetUserGroupList(ids);
```

