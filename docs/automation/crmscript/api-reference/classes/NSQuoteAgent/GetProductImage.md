---
uid: crmscript_ref_NSQuoteAgent_GetProductImage
title: String GetProductImage(Integer quoteConnectionId, String eRPProductKey, Integer rank)
intellisense: NSQuoteAgent.GetProductImage
keywords: NSQuoteAgent, GetProductImage
so.topic: reference
---

Gets an image connected to a product, from the ProductProvider

**Parameters:**
 - **quoteConnectionId** The connection this product comes from.
 - **eRPProductKey** Primary key of the Product in the ProductProvider 
 - **rank** The rank of the image.

**Returns:** String

```crmscript
NSQuoteAgent agent;
Integer quoteConnectionId;
String eRPProductKey;
Integer rank;
String res = agent.GetProductImage(quoteConnectionId, eRPProductKey, rank);
```

