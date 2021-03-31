---
title: crmscript_ref_NSQuoteAgent_GetQuoteVersion
description: QuoteVersion GetQuoteVersion(Integer quoteVersionId)
intellisense: NSQuoteAgent.GetQuoteVersion
keywords: NSQuoteAgent,GetQuoteVersion
so.topic: reference
---

Get a QuoteVersion

**Parameters:**
 - **quoteVersionId** QuoteVersionId to get information from

**Returns:** Array of Quote versions

```crmscript
NSQuoteAgent agent;
Integer quoteVersionId;
QuoteVersion res = agent.GetQuoteVersion(quoteVersionId);
```

