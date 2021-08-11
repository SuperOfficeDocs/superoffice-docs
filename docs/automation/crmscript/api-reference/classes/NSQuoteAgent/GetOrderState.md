---
uid: crmscript_ref_NSQuoteAgent_GetOrderState
title: NSPluginUrlResponse GetOrderState(Integer quoteVersionId)
intellisense: NSQuoteAgent.GetOrderState
keywords: NSQuoteAgent, GetOrderState
so.topic: reference
---

# NSPluginUrlResponse GetOrderState(Integer quoteVersionId)

If there is a problem with a quoteline, the error description shall be placed in the status and reason fields of the quoteline, if there is a problem with the alternative, the error description shall be placed in the status and reason fields of the alternative. A summary of all the problems (if any) should be placed in the response object. Requires that the Create-Order capability is true.

**Parameters:**
 - **quoteVersionId** the QuoteVersionId of the ordered version.

**Returns:** NSPluginUrlResponse

```crmscript
NSQuoteAgent agent;
Integer quoteVersionId;
NSPluginUrlResponse res = agent.GetOrderState(quoteVersionId);
```

