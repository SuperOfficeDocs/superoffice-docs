---
uid: crmscript_ref_NSQuoteAgent_GetQuoteEntityFromSaleId
title: NSQuoteEntity GetQuoteEntityFromSaleId(Integer saleId)
intellisense: NSQuoteAgent.GetQuoteEntityFromSaleId
keywords: NSQuoteAgent, GetQuoteEntityFromSaleId
so.topic: reference
---

# NSQuoteEntity GetQuoteEntityFromSaleId(Integer saleId)

Get a Quote for a sale

**Parameters:**
 - **saleId** SaleId of the Quote to get.

**Returns:** NSQuoteEntity

```crmscript
NSQuoteAgent agent;
Integer saleId;
NSQuoteEntity res = agent.GetQuoteEntityFromSaleId(saleId);
```

