---
uid: crmscript_ref_NSPersonAgent_CheckTemporaryKey
title: TemporaryKeyInfo CheckTemporaryKey(String temporaryKey)
intellisense: NSPersonAgent.CheckTemporaryKey
keywords: NSPersonAgent, CheckTemporaryKey
so.topic: reference
---

Check a temporary key for validity, and in case it is valid, return its domain, targetId and personId

**Parameters:**
 - **temporaryKey** The base64 encoded key value, as returned by CreateTemporaryKey

**Returns:** The info about the temporary key. Domain will be Unknown if key is not valid.

```crmscript
NSPersonAgent agent;
String temporaryKey;
TemporaryKeyInfo res = agent.CheckTemporaryKey(temporaryKey);
```

