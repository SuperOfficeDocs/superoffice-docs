---
uid: crmscript_ref_NSEMailAgent_HasMXRecord
title: Bool HasMXRecord(String mailDomain)
intellisense: NSEMailAgent.HasMXRecord
keywords: NSEMailAgent, HasMXRecord
so.topic: reference
---

Return true if there is one or more MX records in DNS for the given mail domain

**Parameters:**
 - **mailDomain** The mail domain to check. Normally this is the part after @ in an email address

**Returns:** True if there is at least one MX record

```crmscript
NSEMailAgent agent;
String mailDomain;
Bool res = agent.HasMXRecord(mailDomain);
```

