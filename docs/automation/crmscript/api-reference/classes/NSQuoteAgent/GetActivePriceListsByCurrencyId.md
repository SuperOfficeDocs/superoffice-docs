---
uid: crmscript_ref_NSQuoteAgent_GetActivePriceListsByCurrencyId
title: PriceListArray GetActivePriceListsByCurrencyId(Integer quoteConnectionId, Integer currencyId)
intellisense: NSQuoteAgent.GetActivePriceListsByCurrencyId
keywords: NSQuoteAgent, GetActivePriceListsByCurrencyId
so.topic: reference
---

Gets the available active PriceLists in a specific currency. Will return empty array if there is no PriceList with the stated currency available.

**Parameters:**
 - **quoteConnectionId** Primary key of the connection
 - **currencyId** SuperOffice currency id.

**Returns:** The PriceLists that supports a specific currency

```crmscript
NSQuoteAgent agent;
Integer quoteConnectionId;
Integer currencyId;
PriceListArray res = agent.GetActivePriceListsByCurrencyId(quoteConnectionId, currencyId);
```

