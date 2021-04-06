---
uid: crmscript_ref_NSQuoteAgent_GetActivePriceLists
title: PriceListArray GetActivePriceLists(Integer quoteConnectionId, String currency)
intellisense: NSQuoteAgent.GetActivePriceLists
keywords: NSQuoteAgent, GetActivePriceLists
so.topic: reference
---

Gets the available active PriceLists in a specific currency. Will return empty array if there is no PriceList with the stated currency available.

**Parameters:**
 - **quoteConnectionId** Primary key of the connection
 - **currency** Iso currency like: USD or NOK. See http://www.currency-iso.org/dl_iso_table_a1.xls for details. Case insensitive. Will return empty array if there is no PriceList with the stated currency available.

**Returns:** The PriceLists that supports a specific currency

```crmscript
NSQuoteAgent agent;
Integer quoteConnectionId;
String currency;
PriceListArray res = agent.GetActivePriceLists(quoteConnectionId, currency);
```

