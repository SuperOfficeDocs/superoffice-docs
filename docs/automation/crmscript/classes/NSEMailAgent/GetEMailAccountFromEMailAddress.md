---
title: crmscript_ref_NSEMailAgent_GetEMailAccountFromEMailAddress
description: EMailAccount GetEMailAccountFromEMailAddress(String fromAddress)
intellisense: NSEMailAgent.GetEMailAccountFromEMailAddress
keywords: NSEMailAgent,GetEMailAccountFromEMailAddress
so.topic: reference
---

Returns the email account corresponding to this email address (for the current associate).

**Parameters:**
 - **fromAddress** The address associated with this email account

**Returns:** Found or empty email account

```crmscript
NSEMailAgent agent;
String fromAddress;
EMailAccount res = agent.GetEMailAccountFromEMailAddress(fromAddress);
```

