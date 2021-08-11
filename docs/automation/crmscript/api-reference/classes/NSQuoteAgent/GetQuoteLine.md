---
uid: crmscript_ref_NSQuoteAgent_GetQuoteLine
title: NSQuoteLine GetQuoteLine(Integer quoteLineId)
intellisense: NSQuoteAgent.GetQuoteLine
keywords: NSQuoteAgent, GetQuoteLine
so.topic: reference
---

# NSQuoteLine GetQuoteLine(Integer quoteLineId)

Get QuoteLine from database

**Parameters:**
 - **quoteLineId** Primary key of the quoteline to get.

**Returns:** NSQuoteLine

```crmscript
NSQuoteAgent agent;
Integer quoteLineId;
NSQuoteLine res = agent.GetQuoteLine(quoteLineId);
```

