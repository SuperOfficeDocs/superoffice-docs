---
uid: crmscript_ref_NSQuoteAgent_IncludeQuoteVersionAttachment
title: Bool IncludeQuoteVersionAttachment(Integer quoteVersionId, Integer documentId, Bool include)
intellisense: NSQuoteAgent.IncludeQuoteVersionAttachment
keywords: NSQuoteAgent, IncludeQuoteVersionAttachment
so.topic: reference
---

Toggle the 'included' state of a quote version attachment; will throw exceptions if called on locked versions

**Parameters:**
 - **quoteVersionId** The ID of the Quote version
 - **documentId** The ID of the document
 - **include** Desired state

**Returns:** The new state

```crmscript
NSQuoteAgent agent;
Integer quoteVersionId;
Integer documentId;
Bool include;
Bool res = agent.IncludeQuoteVersionAttachment(quoteVersionId, documentId, include);
```

