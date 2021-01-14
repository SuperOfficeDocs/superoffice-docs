---
title: NSPriceList[] GetActivePriceLists(Integer quoteConnectionId, String currency)
path: /EJScript/Classes/NSQuoteAgent/Member functions/NSPriceList[] GetActivePriceLists(Integer p_0, String p_1)
intellisense: 1
classref: 1
sortOrder: 5974
keywords: GetActivePriceLists(Integer,String)
---


Gets the available active PriceLists in a specific currency. Will return empty array if there is no PriceList with the stated currency available.



* **quoteConnectionId:** Primary key of the connection
* **currency:** Iso currency like: USD or NOK. See http://www.currency-iso.org/dl\_iso_table\_a1.xls for details. Case insensitive. Will return empty array if there is no PriceList with the stated currency available.
* **Returns:** The PriceLists that supports a specific currency


