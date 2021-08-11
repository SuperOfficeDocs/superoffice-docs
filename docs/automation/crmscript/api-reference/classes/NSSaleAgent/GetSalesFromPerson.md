---
uid: crmscript_ref_NSSaleAgent_GetSalesFromPerson
title: NSSale[] GetSalesFromPerson(Integer personId, Bool onlyOpenSales)
intellisense: NSSaleAgent.GetSalesFromPerson
keywords: NSSaleAgent, GetSalesFromPerson
so.topic: reference
---

# NSSale[] GetSalesFromPerson(Integer personId, Bool onlyOpenSales)

Returns all sales for the person provided.

**Parameters:**
 - **personId** The ID of the person whose sales we want.
 - **onlyOpenSales** If true, only get open sales.

**Returns:** NSSale[]

```crmscript
NSSaleAgent agent;
Integer personId;
Bool onlyOpenSales;
NSSale[] res = agent.GetSalesFromPerson(personId, onlyOpenSales);
```

