---
uid: crmscript_ref_NSUserAgent_GetServiceAuth
title: NSServiceAuth GetServiceAuth(Integer serviceAuthId);
intellisense: NSUserAgent.GetServiceAuth
keywords: NSUserAgent, GetServiceAuth
so.topic: reference
---

# NSServiceAuth GetServiceAuth(Integer serviceAuthId);

Gets a NSServiceAuth object.

**Parameters:**
 - **serviceAuthId** The identifier of the NSServiceAuth object

**Returns:** NSServiceAuth

```crmscript
NSUserAgent agent;
NSServiceAuth thing = agent.GetServiceAuth(123);
```

