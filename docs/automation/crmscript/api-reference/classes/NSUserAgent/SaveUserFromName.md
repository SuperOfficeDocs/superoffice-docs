---
uid: crmscript_ref_NSUserAgent_SaveUserFromName
title: NSUser SaveUserFromName(String userName, NSUser user)
intellisense: NSUserAgent.SaveUserFromName
keywords: NSUserAgent, SaveUserFromName
so.topic: reference
---

# NSUser SaveUserFromName(String userName, NSUser user)

Save a user, with lookup based on the user name.

**Parameters:**
 - **userName** User name of the user to get.
 - **user** User object to save.

**Returns:** NSUser

```crmscript
NSUserAgent agent;
String userName;
NSUser user;
NSUser res = agent.SaveUserFromName(userName, user);
```

