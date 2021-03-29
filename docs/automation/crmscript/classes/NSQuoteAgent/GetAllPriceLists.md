---
title: crmscript_ref_NSQuoteAgent_GetAllPriceLists_Integer_p_0_String_p_1
description: NSQuoteAgent.GetAllPriceLists(Integer p_0, String p_1)
intellisense: NSQuoteAgent.GetAllPriceLists
keywords: GetAllPriceLists(Integer,String)
so.topic: reference
---


Gets the all PriceLists in all currencies, including those inactive. Will return empty array if there is no PriceList available.



* **quoteConnectionId:** Primary key of the connection
* **currency:** Iso currency like: USD or NOK. See http://www.currency-iso.org/dl\_iso_table\_a1.xls for details. Case insensitive. Will return empty array if there is no PriceList with the stated currency available.
* **Returns:** The PriceLists that supports a specific currency


