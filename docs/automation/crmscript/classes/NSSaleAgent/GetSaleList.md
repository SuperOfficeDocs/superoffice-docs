---
uid: crmscript_ref_NSSaleAgent_GetSaleList
title: NSSale[] GetSaleList(Integer[]  saleIds);
intellisense: NSSaleAgent.GetSaleList
keywords: NSSaleAgent, GetSaleList
so.topic: reference
---

Gets a vector of Sale objects.

**Parameters:**
 - **saleIds** The identifiers of the NSSale objects

**Returns:** Vector of NSSale objects

```crmscript
Integer[] ids;
NSSaleAgent agent;
agent.GetSaleList(ids);
```

