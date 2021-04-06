---
uid: crmscript_ref_NSUserAgent_GetUserFromName
title: User GetUserFromName(String userName)
intellisense: NSUserAgent.GetUserFromName
keywords: NSUserAgent, GetUserFromName
so.topic: reference
---

Get a user, with lookup based on user name.

**Parameters:**
 - **userName** User name of the user to get.

**Returns:** User retrieved by name

```crmscript
NSUserAgent agent;
String userName;
User res = agent.GetUserFromName(userName);
```

