---
title: NSPriceList CopySuperOfficePriceList(Integer originalPriceListId, String newName, DateTime validFrom, DateTime validTo, Integer newCurrencyId, Bool convertCurrency)
path: /EJScript/Classes/NSQuoteAgent/Member functions/NSPriceList CopySuperOfficePriceList(Integer p_0, String p_1, DateTime p_2, DateTime p_3, Integer p_4, Bool p_5)
intellisense: 1
classref: 1
keywords: CopySuperOfficePriceList(Integer,String,DateTime,DateTime,Integer,Bool)
---


Create a copy of a PriceList in the SuperOffice database



* **originalPriceListId:** Id of the PriceList to be copied
* **newName:** Name of the copied PriceList
* **validFrom:** Start date for the new pricelist.
* **validTo:** End date for the new pricelist.
* **newCurrencyId:** Currency id of the copied PriceList. If 0 or the same as the original the copied products will keep their prices and the currency will be the same as the original.
* **convertCurrency:** If true, product prices will be recalculated to the new currency. If false, product prices will be set to zero.
* **Returns:** The copied PriceList


