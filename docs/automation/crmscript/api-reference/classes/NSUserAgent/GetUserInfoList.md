---
uid: crmscript_ref_NSUserAgent_GetUserInfoList
title: NSUserInfo[] GetUserInfoList(Integer[]  userInfoIds);
intellisense: NSUserAgent.GetUserInfoList
keywords: NSUserAgent, GetUserInfoList
so.topic: reference
---

# NSUserInfo[] GetUserInfoList(Integer[]  userInfoIds);

Gets a vector of NSUserInfo objects.

**Parameters:**
 - **userInfoIds** The identifiers of the NSUserInfo objects

**Returns:** NSUserInfo[]

```crmscript
Integer[] ids;
NSUserAgent agent;
agent.GetUserInfoList(ids);
```

