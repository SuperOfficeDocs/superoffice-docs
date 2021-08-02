---
uid: crmscript_ref_NSQuoteAgent_GetQuoteVersionWorkflowState
title: NSQuoteVersionWorkflowState GetQuoteVersionWorkflowState(Integer quoteVersionId, Integer quoteAlternativeId)
intellisense: NSQuoteAgent.GetQuoteVersionWorkflowState
keywords: NSQuoteAgent, GetQuoteVersionWorkflowState
so.topic: reference
---

Get all button states for the Quote version dialog. Packages ImageState, Button states and status info into one call. Collects most important warnings/errors from across all quotelines/alternatives in this quote version.

**Parameters:**
 - **quoteVersionId** Id of the quote version to get the button states for.
 - **quoteAlternativeId** Id of the active quote alternative id.

**Returns:** NSQuoteVersionWorkflowState

```crmscript
NSQuoteAgent agent;
Integer quoteVersionId;
Integer quoteAlternativeId;
NSQuoteVersionWorkflowState res = agent.GetQuoteVersionWorkflowState(quoteVersionId, quoteAlternativeId);
```

