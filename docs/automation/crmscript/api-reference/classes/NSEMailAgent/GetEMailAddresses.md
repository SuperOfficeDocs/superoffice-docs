---
uid: crmscript_ref_NSEMailAgent_GetEMailAddresses
title: EMailAddress[] GetEMailAddresses(Integer[] emailIds)
intellisense: NSEMailAgent.GetEMailAddresses
keywords: NSEMailAgent, GetEMailAddresses
so.topic: reference
---

Get information about one or more email addresses, identified by IDs

**Parameters:**
 - **emailIds** Array of IDs from the email table, each identifying one email address

**Returns:** Array of email information objects

```crmscript
NSEMailAgent agent;
Integer[] emailIds;
EMailAddress[] res = agent.GetEMailAddresses(emailIds);
```

