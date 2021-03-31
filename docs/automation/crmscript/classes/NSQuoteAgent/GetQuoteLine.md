---
uid: crmscript_ref_NSQuoteAgent_GetQuoteLine
title: QuoteLine GetQuoteLine(Integer quoteLineId)
intellisense: NSQuoteAgent.GetQuoteLine
keywords: NSQuoteAgent, GetQuoteLine
so.topic: reference
---

Get QuoteLine from database

**Parameters:**
 - **quoteLineId** Primary key of the quoteline to get.

**Returns:** The updated quote line (If the quoteline was new, it returns with id's set.

```crmscript
NSQuoteAgent agent;
Integer quoteLineId;
QuoteLine res = agent.GetQuoteLine(quoteLineId);
```

