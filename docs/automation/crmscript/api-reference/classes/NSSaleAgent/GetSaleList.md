---
uid: crmscript_ref_NSSaleAgent_GetSaleList
title: NSSale[] GetSaleList(Integer[]  saleIds);
intellisense: NSSaleAgent.GetSaleList
keywords: NSSaleAgent, GetSaleList
so.topic: reference
---

# NSSale[] GetSaleList(Integer[]  saleIds);

Gets a vector of Sale objects.

**Parameters:**
 - **saleIds** The identifiers of the NSSale objects

**Returns:** NSSale[]

```crmscript
Integer[] ids;
NSSaleAgent agent;
agent.GetSaleList(ids);
```

