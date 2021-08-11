---
uid: crmscript_ref_NSUserAgent_ChangePasswordFromName
title: Bool ChangePasswordFromName(String associateName, String oldPassword, String newPassword)
intellisense: NSUserAgent.ChangePasswordFromName
keywords: NSUserAgent, ChangePasswordFromName
so.topic: reference
---

# Bool ChangePasswordFromName(String associateName, String oldPassword, String newPassword)

Change password for a user.

**Parameters:**
 - **associateName** Username of the user to change password for.
 - **oldPassword** The current password of the user.  Administrators can leave this blank to force a new password upon a user.
 - **newPassword** The new password for the user

**Returns:** Bool

```crmscript
NSUserAgent agent;
String associateName;
String oldPassword;
String newPassword;
Bool res = agent.ChangePasswordFromName(associateName, oldPassword, newPassword);
```

