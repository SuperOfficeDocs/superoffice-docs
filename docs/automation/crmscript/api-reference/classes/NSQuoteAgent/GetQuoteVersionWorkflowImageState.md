---
uid: crmscript_ref_NSQuoteAgent_GetQuoteVersionWorkflowImageState
title: NSQuoteVersionButtonState GetQuoteVersionWorkflowImageState(Integer quoteVersionId)
intellisense: NSQuoteAgent.GetQuoteVersionWorkflowImageState
keywords: NSQuoteAgent, GetQuoteVersionWorkflowImageState
so.topic: reference
---

# NSQuoteVersionButtonState GetQuoteVersionWorkflowImageState(Integer quoteVersionId)

Get state icon and name for the Quote version dialog header.

**Parameters:**
 - **quoteVersionId** Id of the quote version to get the version state for.

**Returns:** NSQuoteVersionButtonState

```crmscript
NSQuoteAgent agent;
Integer quoteVersionId;
NSQuoteVersionButtonState res = agent.GetQuoteVersionWorkflowImageState(quoteVersionId);
```

