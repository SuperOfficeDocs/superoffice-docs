---
uid: crmscript_ref_NSQuoteAgent_GetQuoteAlternatives
title: NSQuoteAlternative[] GetQuoteAlternatives(Integer quoteVersionId)
intellisense: NSQuoteAgent.GetQuoteAlternatives
keywords: NSQuoteAgent, GetQuoteAlternatives
so.topic: reference
---

Get all quote alternatives for a quote version

**Parameters:**
 - **quoteVersionId** QuoteVersionId of the revison to get alternatives for.

**Returns:** NSQuoteAlternative[]

```crmscript
NSQuoteAgent agent;
Integer quoteVersionId;
NSQuoteAlternative[] res = agent.GetQuoteAlternatives(quoteVersionId);
```

