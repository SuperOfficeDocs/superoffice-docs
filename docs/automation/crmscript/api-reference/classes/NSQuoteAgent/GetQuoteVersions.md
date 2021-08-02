---
uid: crmscript_ref_NSQuoteAgent_GetQuoteVersions
title: NSQuoteVersion[] GetQuoteVersions(Integer quoteId)
intellisense: NSQuoteAgent.GetQuoteVersions
keywords: NSQuoteAgent, GetQuoteVersions
so.topic: reference
---

Get all quote versions for a sale

**Parameters:**
 - **quoteId** QuoteId of the quote to get versions from

**Returns:** NSQuoteVersion[]

```crmscript
NSQuoteAgent agent;
Integer quoteId;
NSQuoteVersion[] res = agent.GetQuoteVersions(quoteId);
```

