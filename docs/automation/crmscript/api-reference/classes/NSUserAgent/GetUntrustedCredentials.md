---
uid: crmscript_ref_NSUserAgent_GetUntrustedCredentials
title: UntrustedCredentialsArray GetUntrustedCredentials(String type)
intellisense: NSUserAgent.GetUntrustedCredentials
keywords: NSUserAgent, GetUntrustedCredentials
so.topic: reference
---

Get a set of credentials of a specified type for authenticated user.

**Parameters:**
 - **type** Type of credential(Ex: "imap", "smtp").

**Returns:** Array of credentials of the specified type.

```crmscript
NSUserAgent agent;
String type;
UntrustedCredentialsArray res = agent.GetUntrustedCredentials(type);
```

