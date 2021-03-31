---
title: crmscript_ref_NSUserAgent_SaveCredential
description: Bool SaveCredential(Integer userId, Credential credential)
intellisense: NSUserAgent.SaveCredential
keywords: NSUserAgent,SaveCredential
so.topic: reference
---

Save (adds/replaces) current credential of the same type for the user.

**Parameters:**
 - **userId** Primary key of the user (i.e. associate)
 - **credential** Credentials supported for authentication

**Returns:** True if the credential was successfully saved.

```crmscript
NSUserAgent agent;
Integer userId;
Credential credential;
Bool res = agent.SaveCredential(userId, credential);
```

