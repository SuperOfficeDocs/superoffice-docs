---
uid: crmscript_ref_NSUserAgent_SetPasswordFromName
title: Bool SetPasswordFromName(String associateName, String password)
intellisense: NSUserAgent.SetPasswordFromName
keywords: NSUserAgent, SetPasswordFromName
so.topic: reference
---

Change password for a user.

**Parameters:**
 - **associateName** Username to set password for
 - **password** New password

**Returns:** Succeeded?

```crmscript
NSUserAgent agent;
String associateName;
String password;
Bool res = agent.SetPasswordFromName(associateName, password);
```

