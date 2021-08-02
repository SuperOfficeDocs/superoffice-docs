---
uid: crmscript_ref_NSQuoteAgent_GetQuoteFromSaleId
title: NSQuote GetQuoteFromSaleId(Integer saleId)
intellisense: NSQuoteAgent.GetQuoteFromSaleId
keywords: NSQuoteAgent, GetQuoteFromSaleId
so.topic: reference
---

Get a NSQuote for a sale

**Parameters:**
 - **saleId** SaleId of the NSQuote to get.

**Returns:** NSQuote

```crmscript
NSQuoteAgent agent;
Integer saleId;
NSQuote res = agent.GetQuoteFromSaleId(saleId);
```

