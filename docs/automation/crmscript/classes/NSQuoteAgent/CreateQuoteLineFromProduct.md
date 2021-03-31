---
title: crmscript_ref_NSQuoteAgent_CreateQuoteLineFromProduct
description: QuoteLine CreateQuoteLineFromProduct(Integer quoteAlternativeId, Product product)
intellisense: NSQuoteAgent.CreateQuoteLineFromProduct
keywords: NSQuoteAgent,CreateQuoteLineFromProduct
so.topic: reference
---

Create a quoteline based on a product.

**Parameters:**
 - **quoteAlternativeId** Primary key of the alternative
 - **product** Product carrier

**Returns:** The updated quote line.

```crmscript
NSQuoteAgent agent;
Integer quoteAlternativeId;
Product product;
QuoteLine res = agent.CreateQuoteLineFromProduct(quoteAlternativeId, product);
```

