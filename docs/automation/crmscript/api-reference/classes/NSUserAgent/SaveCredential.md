---
uid: crmscript_ref_NSUserAgent_SaveCredential
title: Bool SaveCredential(Integer userId, NSCredential credential)
intellisense: NSUserAgent.SaveCredential
keywords: NSUserAgent, SaveCredential
so.topic: reference
---

# Bool SaveCredential(Integer userId, NSCredential credential)

Save (adds/replaces) current credential of the same type for the user.

**Parameters:**
 - **userId** Primary key of the user (i.e. associate)
 - **credential** Credentials supported for authentication

**Returns:** Bool

```crmscript
NSUserAgent agent;
Integer userId;
NSCredential credential;
Bool res = agent.SaveCredential(userId, credential);
```

