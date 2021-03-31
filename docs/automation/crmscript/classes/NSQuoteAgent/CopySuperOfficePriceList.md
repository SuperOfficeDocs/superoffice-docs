---
title: crmscript_ref_NSQuoteAgent_CopySuperOfficePriceList
description: PriceList CopySuperOfficePriceList(Integer originalPriceListId, String newName, DateTime validFrom, DateTime validTo, Integer newCurrencyId, Bool convertCurrency)
intellisense: NSQuoteAgent.CopySuperOfficePriceList
keywords: NSQuoteAgent,CopySuperOfficePriceList
so.topic: reference
---

Create a copy of a PriceList in the SuperOffice database

**Parameters:**
 - **originalPriceListId** Id of the PriceList to be copied
 - **newName** Name of the copied PriceList
 - **validFrom** Start date for the new pricelist.
 - **validTo** End date for the new pricelist.
 - **newCurrencyId** Currency id of the copied PriceList. If 0 or the same as the original the copied products will keep their prices and the currency will be the same as the original.
 - **convertCurrency** If true, product prices will be recalculated to the new currency. If false, product prices will be set to zero.

**Returns:** The copied PriceList

```crmscript
NSQuoteAgent agent;
Integer originalPriceListId;
String newName;
DateTime validFrom;
DateTime validTo;
Integer newCurrencyId;
Bool convertCurrency;
PriceList res = agent.CopySuperOfficePriceList(originalPriceListId, newName, validFrom, validTo, newCurrencyId, convertCurrency);
```

