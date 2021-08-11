---
uid: crmscript_ref_NSSaleAgent_GetSalesFromContact
title: NSSale[] GetSalesFromContact(Integer contactId, Bool onlyOpenSales)
intellisense: NSSaleAgent.GetSalesFromContact
keywords: NSSaleAgent, GetSalesFromContact
so.topic: reference
---

# NSSale[] GetSalesFromContact(Integer contactId, Bool onlyOpenSales)

Returns all sales for the contact provided.

**Parameters:**
 - **contactId** The ID of the contact whose sales we want.
 - **onlyOpenSales** If true, only get open sales.

**Returns:** NSSale[]

```crmscript
NSSaleAgent agent;
Integer contactId;
Bool onlyOpenSales;
NSSale[] res = agent.GetSalesFromContact(contactId, onlyOpenSales);
```

