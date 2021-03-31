---
title: crmscript_ref_NSCustomerServiceAgent_CreateSession
description: CsSessionKey CreateSession(String remoteIp)
intellisense: NSCustomerServiceAgent.CreateSession
keywords: NSCustomerServiceAgent,CreateSession
so.topic: reference
---

Creates a login session for a CS user

**Parameters:**
 - **remoteIp** The ip of the client creating the session

**Returns:** The session key information

```crmscript
NSCustomerServiceAgent agent;
String remoteIp;
CsSessionKey res = agent.CreateSession(remoteIp);
```

