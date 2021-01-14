---
title: NSPriceList[] GetAllPriceLists(Integer quoteConnectionId, String currency)
path: /EJScript/Classes/NSQuoteAgent/Member functions/NSPriceList[] GetAllPriceLists(Integer p_0, String p_1)
intellisense: 1
classref: 1
keywords: GetAllPriceLists(Integer,String)
---


Gets the all PriceLists in all currencies, including those inactive. Will return empty array if there is no PriceList available.



* **quoteConnectionId:** Primary key of the connection
* **currency:** Iso currency like: USD or NOK. See http://www.currency-iso.org/dl\_iso_table\_a1.xls for details. Case insensitive. Will return empty array if there is no PriceList with the stated currency available.
* **Returns:** The PriceLists that supports a specific currency


