---
uid: crmscript_ref_NSUserAgent_DeleteCredential
title: Bool DeleteCredential(Integer userId, String credentialType)
intellisense: NSUserAgent.DeleteCredential
keywords: NSUserAgent, DeleteCredential
so.topic: reference
---

Remove credential of a specific type for a user

**Parameters:**
 - **userId** Primary key of the user (i.e. associate)
 - **credentialType** Type of credentials, corresponding to name of plugin and type in the credentials table

**Returns:** Bool

```crmscript
NSUserAgent agent;
Integer userId;
String credentialType;
Bool res = agent.DeleteCredential(userId, credentialType);
```

