---
title: crmscript_ref_NSQuoteAgent_GetOrderState
description: PluginUrlResponse GetOrderState(Integer quoteVersionId)
intellisense: NSQuoteAgent.GetOrderState
keywords: NSQuoteAgent,GetOrderState
so.topic: reference
---

If there is a problem with a quoteline, the error description shall be placed in the status and reason fields of the quoteline, if there is a problem with the alternative, the error description shall be placed in the status and reason fields of the alternative. A summary of all the problems (if any) should be placed in the response object. Requires that the Create-Order capability is true.

**Parameters:**
 - **quoteVersionId** the QuoteVersionId of the ordered version.

**Returns:** The order state. If a new quoteversion is created, the QuoteVersionId will be found in Changes.AddedRecords.

```crmscript
NSQuoteAgent agent;
Integer quoteVersionId;
PluginUrlResponse res = agent.GetOrderState(quoteVersionId);
```

