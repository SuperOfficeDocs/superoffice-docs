---
title: crmscript_ref_NSQuoteAgent_GetOrderState_Integer_p_0
description: NSQuoteAgent.GetOrderState(Integer p_0)
intellisense: NSQuoteAgent.GetOrderState
keywords: GetOrderState(Integer)
so.topic: reference
---


If there is a problem with a quoteline, the error description shall be placed in the status and reason fields of the quoteline, if there is a problem with the alternative, the error description shall be placed in the status and reason fields of the alternative. A summary of all the problems (if any) should be placed in the response object. Requires that the Create-Order capability is true.



* **quoteVersionId:** the QuoteVersionId of the ordered version.
* **Returns:** The order state. If a new quoteversion is created, the QuoteVersionId will be found in Changes.AddedRecords.


