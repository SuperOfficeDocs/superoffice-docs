---
uid: crmscript_ref_NSContactAgent_GetQuoteVersionAddresses
title: NSAddress[] GetQuoteVersionAddresses(Integer quoteVersionId)
intellisense: NSContactAgent.GetQuoteVersionAddresses
keywords: NSContactAgent, GetQuoteVersionAddresses
so.topic: reference
---

# NSAddress[] GetQuoteVersionAddresses(Integer quoteVersionId)

Get the associated billing and invoice quote version addresses. These addresses might be address on the contact, or a custom address.

**Parameters:**
 - **quoteVersionId** The version to get the addresses for.

**Returns:** NSAddress[]

```crmscript
NSContactAgent agent;
Integer quoteVersionId;
NSAddress[] res = agent.GetQuoteVersionAddresses(quoteVersionId);
```

