---
uid: crmscript_ref_NSQuoteAgent_ToggleQuoteVersionAttachmentIncluded
title: Bool ToggleQuoteVersionAttachmentIncluded(Integer quoteVersionAttachmentId)
intellisense: NSQuoteAgent.ToggleQuoteVersionAttachmentIncluded
keywords: NSQuoteAgent, ToggleQuoteVersionAttachmentIncluded
so.topic: reference
---

Toggle the 'included' state of a quote version attachment

**Parameters:**
 - **quoteVersionAttachmentId** The ID of the quote version attachment row

**Returns:** Bool

```crmscript
NSQuoteAgent agent;
Integer quoteVersionAttachmentId;
Bool res = agent.ToggleQuoteVersionAttachmentIncluded(quoteVersionAttachmentId);
```

