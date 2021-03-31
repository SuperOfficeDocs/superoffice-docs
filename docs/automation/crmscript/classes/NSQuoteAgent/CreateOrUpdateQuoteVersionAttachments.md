---
title: crmscript_ref_NSQuoteAgent_CreateOrUpdateQuoteVersionAttachments
description: QuoteVersionAttachmentArray CreateOrUpdateQuoteVersionAttachments(Integer quoteVersionId)
intellisense: NSQuoteAgent.CreateOrUpdateQuoteVersionAttachments
keywords: NSQuoteAgent,CreateOrUpdateQuoteVersionAttachments
so.topic: reference
---

Look at the Quote version, related sale and sale type, and ensure that the correct QuoteVersionAttachment records exist. This method may create or delete records

**Parameters:**
 - **quoteVersionId** The ID of the quote version

**Returns:** The current attachments for the given Quote version, after all updates have been completed

```crmscript
NSQuoteAgent agent;
Integer quoteVersionId;
QuoteVersionAttachmentArray res = agent.CreateOrUpdateQuoteVersionAttachments(quoteVersionId);
```

