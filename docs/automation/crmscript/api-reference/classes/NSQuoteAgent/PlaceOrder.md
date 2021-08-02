---
uid: crmscript_ref_NSQuoteAgent_PlaceOrder
title: NSPluginUrlResponse PlaceOrder(Integer quoteAlternativeId, Bool markSaleAsSold, String poNumber, String orderComment, String culture)
intellisense: NSQuoteAgent.PlaceOrder
keywords: NSQuoteAgent, PlaceOrder
so.topic: reference
---

Place an order in the ERP system.

**Parameters:**
 - **quoteAlternativeId** Id of the alternative to place the order on.
 - **markSaleAsSold** Should the state of the owning Sale be set to sold
 - **poNumber** Purchase order number, saved to Quote record
 - **orderComment** Order comment, saved to Quote record
 - **culture** Desired culture for email body and other culture-sensitive templates/content

**Returns:** NSPluginUrlResponse

```crmscript
NSQuoteAgent agent;
Integer quoteAlternativeId;
Bool markSaleAsSold;
String poNumber;
String orderComment;
String culture;
NSPluginUrlResponse res = agent.PlaceOrder(quoteAlternativeId, markSaleAsSold, poNumber, orderComment, culture);
```

