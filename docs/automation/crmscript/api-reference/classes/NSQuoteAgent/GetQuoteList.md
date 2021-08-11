---
uid: crmscript_ref_NSQuoteAgent_GetQuoteList
title: NSQuoteListItem[] GetQuoteList(String quoteListType)
intellisense: NSQuoteAgent.GetQuoteList
keywords: NSQuoteAgent, GetQuoteList
so.topic: reference
---

# NSQuoteListItem[] GetQuoteList(String quoteListType)

Gets a named list from the connector Return array of QuoteListItems. Return NULL if the given list is not supported.

**Parameters:**
 - **quoteListType** The name of the requested list, for instance: ProductCategory, ProductFamily, ProductType, PaymentTerms, PaymentType, DeliveryTerms, DeliveryType.

**Returns:** NSQuoteListItem[]

```crmscript
NSQuoteAgent agent;
String quoteListType;
NSQuoteListItem[] res = agent.GetQuoteList(quoteListType);
```

