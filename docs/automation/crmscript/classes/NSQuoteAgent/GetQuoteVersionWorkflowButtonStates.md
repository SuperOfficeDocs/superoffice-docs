---
title: crmscript_ref_NSQuoteAgent_GetQuoteVersionWorkflowButtonStates
description: QuoteVersionWorkflowState GetQuoteVersionWorkflowButtonStates(Integer quoteVersionId, Integer quoteAlternativeId)
intellisense: NSQuoteAgent.GetQuoteVersionWorkflowButtonStates
keywords: NSQuoteAgent,GetQuoteVersionWorkflowButtonStates
so.topic: reference
---

Get all button states for the Quote version dialog.

**Parameters:**
 - **quoteVersionId** Id of the quote version to get the button states for.
 - **quoteAlternativeId** Id of the active quote alternative id.

**Returns:** Workflow state information

```crmscript
NSQuoteAgent agent;
Integer quoteVersionId;
Integer quoteAlternativeId;
QuoteVersionWorkflowState res = agent.GetQuoteVersionWorkflowButtonStates(quoteVersionId, quoteAlternativeId);
```

