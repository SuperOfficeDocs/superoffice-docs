---
uid: crmscript_ref_NSCustomerServiceAgent_SessionIsValid
title: Bool SessionIsValid(String csSessionKey)
intellisense: NSCustomerServiceAgent.SessionIsValid
keywords: NSCustomerServiceAgent, SessionIsValid
so.topic: reference
---

Check if a CS session is valid

**Parameters:**
 - **csSessionKey** The CS session key to check

**Returns:** Bool

```crmscript
NSCustomerServiceAgent agent;
String csSessionKey;
Bool res = agent.SessionIsValid(csSessionKey);
```

