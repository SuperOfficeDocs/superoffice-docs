---
title: crmscript_ref_NSQuoteAgent_GetQuoteEntityFromSaleId
description: QuoteEntity GetQuoteEntityFromSaleId(Integer saleId)
intellisense: NSQuoteAgent.GetQuoteEntityFromSaleId
keywords: NSQuoteAgent,GetQuoteEntityFromSaleId
so.topic: reference
---

Get a Quote for a sale

**Parameters:**
 - **saleId** SaleId of the Quote to get.

**Returns:** The Quote

```crmscript
NSQuoteAgent agent;
Integer saleId;
QuoteEntity res = agent.GetQuoteEntityFromSaleId(saleId);
```

