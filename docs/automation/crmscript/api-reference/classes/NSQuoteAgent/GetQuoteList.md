---
uid: crmscript_ref_NSQuoteAgent_GetQuoteList
title: QuoteListItem[] GetQuoteList(String quoteListType)
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
QuoteListItem[] res = agent.GetQuoteList(quoteListType);
```

