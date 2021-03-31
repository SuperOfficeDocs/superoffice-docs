---
title: crmscript_ref_NSUserAgent_SaveUserFromName
description: User SaveUserFromName(String userName, User user)
intellisense: NSUserAgent.SaveUserFromName
keywords: NSUserAgent,SaveUserFromName
so.topic: reference
---

Save a user, with lookup based on the user name.

**Parameters:**
 - **userName** User name of the user to get.
 - **user** User object to save.

**Returns:** User retrieved by name

```crmscript
NSUserAgent agent;
String userName;
User user;
User res = agent.SaveUserFromName(userName, user);
```

