---
uid: crmscript_ref_NSUserAgent_GenerateNewPasswordForExternalUser
title: String GenerateNewPasswordForExternalUser(String associateName)
intellisense: NSUserAgent.GenerateNewPasswordForExternalUser
keywords: NSUserAgent, GenerateNewPasswordForExternalUser
so.topic: reference
---

Generates a new password for an external user.

**Parameters:**
 - **associateName** The name of the associate to change the password for.

**Returns:** String

```crmscript
NSUserAgent agent;
String associateName;
String res = agent.GenerateNewPasswordForExternalUser(associateName);
```

