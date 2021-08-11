---
uid: crmscript_ref_NSQuoteAgent_CreateOrUpdateQuoteVersionAttachments
title: NSQuoteVersionAttachment[] CreateOrUpdateQuoteVersionAttachments(Integer quoteVersionId)
intellisense: NSQuoteAgent.CreateOrUpdateQuoteVersionAttachments
keywords: NSQuoteAgent, CreateOrUpdateQuoteVersionAttachments
so.topic: reference
---

# NSQuoteVersionAttachment[] CreateOrUpdateQuoteVersionAttachments(Integer quoteVersionId)

Look at the Quote version, related sale and sale type, and ensure that the correct NSQuoteVersionAttachment records exist. This method may create or delete records

**Parameters:**
 - **quoteVersionId** The ID of the quote version

**Returns:** NSQuoteVersionAttachment[]

```crmscript
NSQuoteAgent agent;
Integer quoteVersionId;
NSQuoteVersionAttachment[] res = agent.CreateOrUpdateQuoteVersionAttachments(quoteVersionId);
```

