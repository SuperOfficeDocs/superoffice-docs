---
title: crmscript_ref_NSEMailAgent_GetEMailAddresses
description: EMailAddressArray GetEMailAddresses(IntegerArray emailIds)
intellisense: NSEMailAgent.GetEMailAddresses
keywords: NSEMailAgent,GetEMailAddresses
so.topic: reference
---

Get information about one or more email addresses, identified by IDs

**Parameters:**
 - **emailIds** Array of IDs from the email table, each identifying one email address

**Returns:** Array of email information objects

```crmscript
NSEMailAgent agent;
IntegerArray emailIds;
EMailAddressArray res = agent.GetEMailAddresses(emailIds);
```

