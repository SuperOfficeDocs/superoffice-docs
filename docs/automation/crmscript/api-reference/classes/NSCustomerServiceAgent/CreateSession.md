---
uid: crmscript_ref_NSCustomerServiceAgent_CreateSession
title: NSCsSessionKey CreateSession(String remoteIp)
intellisense: NSCustomerServiceAgent.CreateSession
keywords: NSCustomerServiceAgent, CreateSession
so.topic: reference
---

# NSCsSessionKey CreateSession(String remoteIp)

Creates a login session for a CS user

**Parameters:**
 - **remoteIp** The ip of the client creating the session

**Returns:** NSCsSessionKey

```crmscript
NSCustomerServiceAgent agent;
String remoteIp;
NSCsSessionKey res = agent.CreateSession(remoteIp);
```

