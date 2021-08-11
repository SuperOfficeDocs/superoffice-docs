---
uid: crmscript_ref_NSQuoteAgent_CreateAndSaveQuoteFromSale
title: NSQuoteEntity CreateAndSaveQuoteFromSale(Integer copyFromSaleId, Integer copyToSaleId)
intellisense: NSQuoteAgent.CreateAndSaveQuoteFromSale
keywords: NSQuoteAgent, CreateAndSaveQuoteFromSale
so.topic: reference
---

# NSQuoteEntity CreateAndSaveQuoteFromSale(Integer copyFromSaleId, Integer copyToSaleId)

Creates a copy the active version with connected alternatives and quotelines from another sale.

**Parameters:**
 - **copyFromSaleId** Id of the sale to copy the active quote from.
 - **copyToSaleId** Id of the sale to copy the active quote to.

**Returns:** NSQuoteEntity

```crmscript
NSQuoteAgent agent;
Integer copyFromSaleId;
Integer copyToSaleId;
NSQuoteEntity res = agent.CreateAndSaveQuoteFromSale(copyFromSaleId, copyToSaleId);
```

