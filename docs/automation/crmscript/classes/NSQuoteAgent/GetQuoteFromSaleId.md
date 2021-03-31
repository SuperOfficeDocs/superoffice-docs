---
title: crmscript_ref_NSQuoteAgent_GetQuoteFromSaleId
description: Quote GetQuoteFromSaleId(Integer saleId)
intellisense: NSQuoteAgent.GetQuoteFromSaleId
keywords: NSQuoteAgent,GetQuoteFromSaleId
so.topic: reference
---

Get a Quote for a sale

**Parameters:**
 - **saleId** SaleId of the Quote to get.

**Returns:** The Quote

```crmscript
NSQuoteAgent agent;
Integer saleId;
Quote res = agent.GetQuoteFromSaleId(saleId);
```

