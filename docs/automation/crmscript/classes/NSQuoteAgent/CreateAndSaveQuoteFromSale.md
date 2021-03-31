---
title: crmscript_ref_NSQuoteAgent_CreateAndSaveQuoteFromSale
description: QuoteEntity CreateAndSaveQuoteFromSale(Integer copyFromSaleId, Integer copyToSaleId)
intellisense: NSQuoteAgent.CreateAndSaveQuoteFromSale
keywords: NSQuoteAgent,CreateAndSaveQuoteFromSale
so.topic: reference
---

Creates a copy the active version with connected alternatives and quotelines from another sale.

**Parameters:**
 - **copyFromSaleId** Id of the sale to copy the active quote from.
 - **copyToSaleId** Id of the sale to copy the active quote to.

**Returns:** The created Quote

```crmscript
NSQuoteAgent agent;
Integer copyFromSaleId;
Integer copyToSaleId;
QuoteEntity res = agent.CreateAndSaveQuoteFromSale(copyFromSaleId, copyToSaleId);
```

