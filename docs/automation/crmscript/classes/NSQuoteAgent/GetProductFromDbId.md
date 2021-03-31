---
uid: crmscript_ref_NSQuoteAgent_GetProductFromDbId
title: Product GetProductFromDbId(Integer productId)
intellisense: NSQuoteAgent.GetProductFromDbId
keywords: NSQuoteAgent, GetProductFromDbId
so.topic: reference
---

Get a product with the given database id

**Parameters:**
 - **productId** The database id of the product

**Returns:** The product info

```crmscript
NSQuoteAgent agent;
Integer productId;
Product res = agent.GetProductFromDbId(productId);
```

