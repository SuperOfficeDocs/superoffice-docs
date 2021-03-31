---
title: crmscript_ref_NSUserAgent_GetUserInfoList
description: NSUserInfo[] GetUserInfoList(Integer[]  userInfoIds);
intellisense: NSUserAgent.GetUserInfoList
keywords: NSUserAgent,GetUserInfoList
so.topic: reference
---

Gets a vector of UserInfo objects.

**Parameters:**
 - **userInfoIds** The identifiers of the NSUserInfo objects

**Returns:** Vector of NSUserInfo objects

```crmscript
Integer[] ids;
NSUserAgent agent;
agent.GetUserInfoList(ids);
```

