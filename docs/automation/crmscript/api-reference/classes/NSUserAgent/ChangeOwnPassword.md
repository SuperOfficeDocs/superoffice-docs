---
uid: crmscript_ref_NSUserAgent_ChangeOwnPassword
title: Bool ChangeOwnPassword(String oldPassword, String newPassword)
intellisense: NSUserAgent.ChangeOwnPassword
keywords: NSUserAgent, ChangeOwnPassword
so.topic: reference
---

Change password for a user.

**Parameters:**
 - **oldPassword** The current password of the user.  Administrators can leave this blank to force a new password upon a user.
 - **newPassword** The new password for the user

**Returns:** Bool

```crmscript
NSUserAgent agent;
String oldPassword;
String newPassword;
Bool res = agent.ChangeOwnPassword(oldPassword, newPassword);
```

