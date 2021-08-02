---
uid: crmscript_ref_NSQuoteAgent_CreateAndSaveQuoteVersion
title: NSQuoteVersion CreateAndSaveQuoteVersion(Integer quoteVersionId)
intellisense: NSQuoteAgent.CreateAndSaveQuoteVersion
keywords: NSQuoteAgent, CreateAndSaveQuoteVersion
so.topic: reference
---

Created a new NSQuoteVersion based on another NSQuoteVersion on the same Quote.

**Parameters:**
 - **quoteVersionId** QuoteVersionId of the version to copy the contents from.

**Returns:** NSQuoteVersion

```crmscript
NSQuoteAgent agent;
Integer quoteVersionId;
NSQuoteVersion res = agent.CreateAndSaveQuoteVersion(quoteVersionId);
```

