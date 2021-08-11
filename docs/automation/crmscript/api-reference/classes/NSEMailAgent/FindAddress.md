---
uid: crmscript_ref_NSEMailAgent_FindAddress
title: NSEMailAddress[] FindAddress(String address)
intellisense: NSEMailAgent.FindAddress
keywords: NSEMailAgent, FindAddress
so.topic: reference
---

# NSEMailAddress[] FindAddress(String address)

Search for contacts and persons with the specified e-mail address (exact match on the email address string required)

**Parameters:**
 - **address** E-mail address to look for

**Returns:** NSEMailAddress[]

```crmscript
NSEMailAgent agent;
String address;
NSEMailAddress[] res = agent.FindAddress(address);
```

