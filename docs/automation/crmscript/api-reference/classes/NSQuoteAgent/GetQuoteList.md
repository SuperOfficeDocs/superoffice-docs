---
uid: crmscript_ref_NSQuoteAgent_GetQuoteList
title: QuoteListItemArray GetQuoteList(String quoteListType)
intellisense: NSQuoteAgent.GetQuoteList
keywords: NSQuoteAgent, GetQuoteList
so.topic: reference
---

Gets a named list from the connector Return array of QuoteListItems. Return NULL if the given list is not supported.

**Parameters:**
 - **quoteListType** The name of the requested list, for instance: ProductCategory, ProductFamily, ProductType, PaymentTerms, PaymentType, DeliveryTerms, DeliveryType.

**Returns:** The list items

```crmscript
NSQuoteAgent agent;
String quoteListType;
QuoteListItemArray res = agent.GetQuoteList(quoteListType);
```

