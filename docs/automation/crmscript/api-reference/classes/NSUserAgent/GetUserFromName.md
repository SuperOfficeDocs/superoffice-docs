---
uid: crmscript_ref_NSUserAgent_GetUserFromName
title: NSUser GetUserFromName(String userName)
intellisense: NSUserAgent.GetUserFromName
keywords: NSUserAgent, GetUserFromName
so.topic: reference
---

# NSUser GetUserFromName(String userName)

Get a user, with lookup based on user name.

**Parameters:**
 - **userName** User name of the user to get.

**Returns:** NSUser

```crmscript
NSUserAgent agent;
String userName;
NSUser res = agent.GetUserFromName(userName);
```

