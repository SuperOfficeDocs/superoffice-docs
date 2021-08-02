---
uid: crmscript_ref_NSQuoteAgent_GetActivePriceLists
title: NSPriceList[] GetActivePriceLists(Integer quoteConnectionId, String currency)
intellisense: NSQuoteAgent.GetActivePriceLists
keywords: NSQuoteAgent, GetActivePriceLists
so.topic: reference
---

Gets the available active PriceLists in a specific currency. Will return empty array if there is no PriceList with the stated currency available.

**Parameters:**
 - **quoteConnectionId** Primary key of the connection
 - **currency** Iso currency like: USD or NOK. See http://www.currency-iso.org/dl_iso_table_a1.xls for details. Case insensitive. Will return empty array if there is no PriceList with the stated currency available.

**Returns:** NSPriceList[]

```crmscript
NSQuoteAgent agent;
Integer quoteConnectionId;
String currency;
NSPriceList[] res = agent.GetActivePriceLists(quoteConnectionId, currency);
```

