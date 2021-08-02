---
uid: crmscript_ref_NSUserAgent_SetPassword
title: Bool SetPassword(Integer associateId, String password)
intellisense: NSUserAgent.SetPassword
keywords: NSUserAgent, SetPassword
so.topic: reference
---

Change password for a user.

**Parameters:**
 - **associateId** Id of User to set password for
 - **password** New password

**Returns:** Bool

```crmscript
NSUserAgent agent;
Integer associateId;
String password;
Bool res = agent.SetPassword(associateId, password);
```

