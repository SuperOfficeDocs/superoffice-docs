---
title: crmscript_ref_NSQuoteAgent_GetActivePriceLists_Integer_p_0_String_p_1
description: NSQuoteAgent.GetActivePriceLists(Integer p_0, String p_1)
intellisense: NSQuoteAgent.GetActivePriceLists
keywords: GetActivePriceLists(Integer,String)
so.topic: reference
---


Gets the available active PriceLists in a specific currency. Will return empty array if there is no PriceList with the stated currency available.



* **quoteConnectionId:** Primary key of the connection
* **currency:** Iso currency like: USD or NOK. See http://www.currency-iso.org/dl\_iso_table\_a1.xls for details. Case insensitive. Will return empty array if there is no PriceList with the stated currency available.
* **Returns:** The PriceLists that supports a specific currency


