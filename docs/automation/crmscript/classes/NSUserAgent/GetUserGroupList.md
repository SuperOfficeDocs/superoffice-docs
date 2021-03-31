---
title: crmscript_ref_NSUserAgent_GetUserGroupList
description: NSUserGroup[] GetUserGroupList(Integer[]  userGroupIds);
intellisense: NSUserAgent.GetUserGroupList
keywords: NSUserAgent,GetUserGroupList
so.topic: reference
---

Gets a vector of UserGroup objects.

**Parameters:**
 - **userGroupIds** The identifiers of the NSUserGroup objects

**Returns:** Vector of NSUserGroup objects

```crmscript
Integer[] ids;
NSUserAgent agent;
agent.GetUserGroupList(ids);
```

