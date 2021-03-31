---
title: crmscript_ref_NSCustomerServiceAgent_SessionIsValid
description: Bool SessionIsValid(String csSessionKey)
intellisense: NSCustomerServiceAgent.SessionIsValid
keywords: NSCustomerServiceAgent,SessionIsValid
so.topic: reference
---

Check if a CS session is valid

**Parameters:**
 - **csSessionKey** The CS session key to check

**Returns:** True if there is a valid CS session based on the session key

```crmscript
NSCustomerServiceAgent agent;
String csSessionKey;
Bool res = agent.SessionIsValid(csSessionKey);
```

