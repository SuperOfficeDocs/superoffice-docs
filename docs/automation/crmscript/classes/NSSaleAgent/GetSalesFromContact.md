---
uid: crmscript_ref_NSSaleAgent_GetSalesFromContact
title: SaleArray GetSalesFromContact(Integer contactId, Bool onlyOpenSales)
intellisense: NSSaleAgent.GetSalesFromContact
keywords: NSSaleAgent, GetSalesFromContact
so.topic: reference
---

Returns all sales for the contact provided.

**Parameters:**
 - **contactId** The ID of the contact whose sales we want.
 - **onlyOpenSales** If true, only get open sales.

**Returns:** List of sales matching query

```crmscript
NSSaleAgent agent;
Integer contactId;
Bool onlyOpenSales;
SaleArray res = agent.GetSalesFromContact(contactId, onlyOpenSales);
```

