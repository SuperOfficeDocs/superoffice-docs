---
uid: crmscript_ref_NSEMailAgent_FindAddress
title: EMailAddressArray FindAddress(String address)
intellisense: NSEMailAgent.FindAddress
keywords: NSEMailAgent, FindAddress
so.topic: reference
---

Search for contacts and persons with the specified e-mail address (exact match on the email address string required)

**Parameters:**
 - **address** E-mail address to look for

**Returns:** All resolved contacts/persons

```crmscript
NSEMailAgent agent;
String address;
EMailAddressArray res = agent.FindAddress(address);
```

