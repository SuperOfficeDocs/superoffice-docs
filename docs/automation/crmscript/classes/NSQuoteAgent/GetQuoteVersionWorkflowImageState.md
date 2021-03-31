---
uid: crmscript_ref_NSQuoteAgent_GetQuoteVersionWorkflowImageState
title: QuoteVersionButtonState GetQuoteVersionWorkflowImageState(Integer quoteVersionId)
intellisense: NSQuoteAgent.GetQuoteVersionWorkflowImageState
keywords: NSQuoteAgent, GetQuoteVersionWorkflowImageState
so.topic: reference
---

Get state icon and name for the Quote version dialog header.

**Parameters:**
 - **quoteVersionId** Id of the quote version to get the version state for.

**Returns:** Image and state name information

```crmscript
NSQuoteAgent agent;
Integer quoteVersionId;
QuoteVersionButtonState res = agent.GetQuoteVersionWorkflowImageState(quoteVersionId);
```

