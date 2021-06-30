---
uid: crmscript_ref_NSQuoteAgent_FindProduct
title: Product[] FindProduct(Integer quoteAlternativeId, String userInput, String priceListKey)
intellisense: NSQuoteAgent.FindProduct
keywords: NSQuoteAgent, FindProduct
so.topic: reference
---

Gets a product, from the ProductProvider

**Parameters:**
 - **quoteAlternativeId** Quote alternative to search in.
 - **userInput** search string
 - **priceListKey** If the pricelist is null or empty, the function will search in all active pricelists.

**Returns:** Product array

```crmscript
NSQuoteAgent agent;
Integer quoteAlternativeId;
String userInput;
String priceListKey;
Product[] res = agent.FindProduct(quoteAlternativeId, userInput, priceListKey);
```

