---
uid: crmscript_ref_NSUserAgent_GetUntrustedCredentials
title: NSUntrustedCredentials[] GetUntrustedCredentials(String type)
intellisense: NSUserAgent.GetUntrustedCredentials
keywords: NSUserAgent, GetUntrustedCredentials
so.topic: reference
---

Get a set of credentials of a specified type for authenticated user.

**Parameters:**
 - **type** Type of credential(Ex: "imap", "smtp").

**Returns:** NSUntrustedCredentials[]

```crmscript
NSUserAgent agent;
String type;
NSUntrustedCredentials[] res = agent.GetUntrustedCredentials(type);
```

