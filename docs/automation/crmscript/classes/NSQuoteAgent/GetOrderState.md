---
title: NSPluginUrlResponse GetOrderState(Integer quoteVersionId)
path: /EJScript/Classes/NSQuoteAgent/Member functions/NSPluginUrlResponse GetOrderState(Integer p_0)
intellisense: 1
classref: 1
keywords: GetOrderState(Integer)
---


If there is a problem with a quoteline, the error description shall be placed in the status and reason fields of the quoteline, if there is a problem with the alternative, the error description shall be placed in the status and reason fields of the alternative. A summary of all the problems (if any) should be placed in the response object. Requires that the Create-Order capability is true.



* **quoteVersionId:** the QuoteVersionId of the ordered version.
* **Returns:** The order state. If a new quoteversion is created, the QuoteVersionId will be found in Changes.AddedRecords.


