---
title: crmscript_ref_NSQuoteAgent_GetAllPriceListsByCurrencyId
description: PriceListArray GetAllPriceListsByCurrencyId(Integer quoteConnectionId, Integer currencyId)
intellisense: NSQuoteAgent.GetAllPriceListsByCurrencyId
keywords: NSQuoteAgent,GetAllPriceListsByCurrencyId
so.topic: reference
---

Gets the all PriceLists in all currencies, including those inactive. Will return empty array if there is no PriceList available.

**Parameters:**
 - **quoteConnectionId** Primary key of the connection
 - **currencyId** SuperOffice currency id.

**Returns:** The PriceLists that supports a specific currency

```crmscript
NSQuoteAgent agent;
Integer quoteConnectionId;
Integer currencyId;
PriceListArray res = agent.GetAllPriceListsByCurrencyId(quoteConnectionId, currencyId);
```

