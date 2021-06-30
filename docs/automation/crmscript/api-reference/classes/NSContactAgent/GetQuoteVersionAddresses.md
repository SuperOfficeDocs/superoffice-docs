---
uid: crmscript_ref_NSContactAgent_GetQuoteVersionAddresses
title: Address[] GetQuoteVersionAddresses(Integer quoteVersionId)
intellisense: NSContactAgent.GetQuoteVersionAddresses
keywords: NSContactAgent, GetQuoteVersionAddresses
so.topic: reference
---

Get the associated billing and invoice quote version addresses. These addresses might be address on the contact, or a custom address.

**Parameters:**
 - **quoteVersionId** The version to get the addresses for.

**Returns:** The quote version addresses. Invoice and billing address, in that order.

```crmscript
NSContactAgent agent;
Integer quoteVersionId;
Address[] res = agent.GetQuoteVersionAddresses(quoteVersionId);
```

