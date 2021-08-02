---
uid: crmscript_ref_NSListAgent_GetSaleTypeList
title: NSSaleType[] GetSaleTypeList(Integer[]  saleTypeIds);
intellisense: NSListAgent.GetSaleTypeList
keywords: NSListAgent, GetSaleTypeList
so.topic: reference
---

Gets a vector of NSSaleType objects.

**Parameters:**
 - **saleTypeIds** The identifiers of the NSSaleType objects

**Returns:** NSSaleType[]

```crmscript
Integer[] ids;
NSListAgent agent;
NSSaleType[] res = agent.GetSaleTypeList(ids);
```

