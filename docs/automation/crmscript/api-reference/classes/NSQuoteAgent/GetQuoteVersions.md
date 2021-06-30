---
uid: crmscript_ref_NSQuoteAgent_GetQuoteVersions
title: QuoteVersion[] GetQuoteVersions(Integer quoteId)
intellisense: NSQuoteAgent.GetQuoteVersions
keywords: NSQuoteAgent, GetQuoteVersions
so.topic: reference
---

Get all quote versions for a sale

**Parameters:**
 - **quoteId** QuoteId of the quote to get versions from

**Returns:** Array of Quote versions

```crmscript
NSQuoteAgent agent;
Integer quoteId;
QuoteVersion[] res = agent.GetQuoteVersions(quoteId);
```

