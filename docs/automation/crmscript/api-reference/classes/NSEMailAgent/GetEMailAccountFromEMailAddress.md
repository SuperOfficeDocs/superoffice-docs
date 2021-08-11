---
uid: crmscript_ref_NSEMailAgent_GetEMailAccountFromEMailAddress
title: NSEMailAccount GetEMailAccountFromEMailAddress(String fromAddress)
intellisense: NSEMailAgent.GetEMailAccountFromEMailAddress
keywords: NSEMailAgent, GetEMailAccountFromEMailAddress
so.topic: reference
---

# NSEMailAccount GetEMailAccountFromEMailAddress(String fromAddress)

Returns the email account corresponding to this email address (for the current associate).

**Parameters:**
 - **fromAddress** The address associated with this email account

**Returns:** NSEMailAccount

```crmscript
NSEMailAgent agent;
String fromAddress;
NSEMailAccount res = agent.GetEMailAccountFromEMailAddress(fromAddress);
```

