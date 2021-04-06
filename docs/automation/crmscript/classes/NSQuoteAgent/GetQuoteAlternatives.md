---
uid: crmscript_ref_NSQuoteAgent_GetQuoteAlternatives
title: QuoteAlternativeArray GetQuoteAlternatives(Integer quoteVersionId)
intellisense: NSQuoteAgent.GetQuoteAlternatives
keywords: NSQuoteAgent, GetQuoteAlternatives
so.topic: reference
---

Get all quote alternatives for a quote version

**Parameters:**
 - **quoteVersionId** QuoteVersionId of the revison to get alternatives for.

**Returns:** Array of Quote alternatives

```crmscript
NSQuoteAgent agent;
Integer quoteVersionId;
QuoteAlternativeArray res = agent.GetQuoteAlternatives(quoteVersionId);
```

