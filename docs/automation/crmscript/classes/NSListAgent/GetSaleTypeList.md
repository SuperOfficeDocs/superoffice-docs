---
uid: crmscript_ref_NSListAgent_GetSaleTypeList
title: NSSaleType[] GetSaleTypeList(Integer[]  saleTypeIds);
intellisense: NSListAgent.GetSaleTypeList
keywords: NSListAgent, GetSaleTypeList
so.topic: reference
---

Gets a vector of SaleType objects.

**Parameters:**
 - **saleTypeIds** The identifiers of the NSSaleType objects

**Returns:** Vector of NSSaleType objects

```crmscript
Integer[] ids;
NSListAgent agent;
agent.GetSaleTypeList(ids);
```

