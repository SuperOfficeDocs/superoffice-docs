---
title: crmscript_ref_NSQuoteAgent_CreateAndSaveQuoteVersion
description: QuoteVersion CreateAndSaveQuoteVersion(Integer quoteVersionId)
intellisense: NSQuoteAgent.CreateAndSaveQuoteVersion
keywords: NSQuoteAgent,CreateAndSaveQuoteVersion
so.topic: reference
---

Created a new QuoteVersion based on another QuoteVersion on the same Quote.

**Parameters:**
 - **quoteVersionId** QuoteVersionId of the version to copy the contents from.

**Returns:** The Quote version

```crmscript
NSQuoteAgent agent;
Integer quoteVersionId;
QuoteVersion res = agent.CreateAndSaveQuoteVersion(quoteVersionId);
```

