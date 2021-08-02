---
uid: crmscript_ref_NSQuoteAgent_GetQuoteVersionWorkflowStatusInfo
title: NSQuoteVersionStatusInformation GetQuoteVersionWorkflowStatusInfo(Integer quoteVersionId)
intellisense: NSQuoteAgent.GetQuoteVersionWorkflowStatusInfo
keywords: NSQuoteAgent, GetQuoteVersionWorkflowStatusInfo
so.topic: reference
---

Get status info for the Quote version dialog header. Collects most important warnings/errors from across all quotelines/alternatives in this quote version.

**Parameters:**
 - **quoteVersionId** Id of the quote version to get the status info for.

**Returns:** NSQuoteVersionStatusInformation

```crmscript
NSQuoteAgent agent;
Integer quoteVersionId;
NSQuoteVersionStatusInformation res = agent.GetQuoteVersionWorkflowStatusInfo(quoteVersionId);
```

