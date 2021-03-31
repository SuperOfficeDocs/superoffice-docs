---
title: crmscript_ref_NSQuoteAgent_GetQuoteLines
description: QuoteLineArray GetQuoteLines(Integer quoteAlternativeId)
intellisense: NSQuoteAgent.GetQuoteLines
keywords: NSQuoteAgent,GetQuoteLines
so.topic: reference
---

Get all QuoteLines from an alternative

**Parameters:**
 - **quoteAlternativeId** Id of the alternative to return the quotelines for

**Returns:** QuoteLine array

```crmscript
NSQuoteAgent agent;
Integer quoteAlternativeId;
QuoteLineArray res = agent.GetQuoteLines(quoteAlternativeId);
```

