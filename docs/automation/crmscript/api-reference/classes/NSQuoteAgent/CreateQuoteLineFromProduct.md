---
uid: crmscript_ref_NSQuoteAgent_CreateQuoteLineFromProduct
title: NSQuoteLine CreateQuoteLineFromProduct(Integer quoteAlternativeId, NSProduct product)
intellisense: NSQuoteAgent.CreateQuoteLineFromProduct
keywords: NSQuoteAgent, CreateQuoteLineFromProduct
so.topic: reference
---

# NSQuoteLine CreateQuoteLineFromProduct(Integer quoteAlternativeId, NSProduct product)

Create a quoteline based on a product.

**Parameters:**
 - **quoteAlternativeId** Primary key of the alternative
 - **product** NSProduct carrier

**Returns:** NSQuoteLine

```crmscript
NSQuoteAgent agent;
Integer quoteAlternativeId;
NSProduct product;
NSQuoteLine res = agent.CreateQuoteLineFromProduct(quoteAlternativeId, product);
```

