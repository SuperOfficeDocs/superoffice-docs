---
uid: crmscript_ref_NSQuoteAgent_GetProductFromDbId
title: NSProduct GetProductFromDbId(Integer productId)
intellisense: NSQuoteAgent.GetProductFromDbId
keywords: NSQuoteAgent, GetProductFromDbId
so.topic: reference
---

# NSProduct GetProductFromDbId(Integer productId)

Get a product with the given database id

**Parameters:**
 - **productId** The database id of the product

**Returns:** NSProduct

```crmscript
NSQuoteAgent agent;
Integer productId;
NSProduct res = agent.GetProductFromDbId(productId);
```

