---
uid: crmscript_ref_NSQuoteAgent_ToggleSaleTypeQuoteAttachmentDefaultIncluded
title: Bool ToggleSaleTypeQuoteAttachmentDefaultIncluded(Integer saleTypeQuoteAttachmentId)
intellisense: NSQuoteAgent.ToggleSaleTypeQuoteAttachmentDefaultIncluded
keywords: NSQuoteAgent, ToggleSaleTypeQuoteAttachmentDefaultIncluded
so.topic: reference
---

Toggle the 'default included' state of a sale type quote attachment

**Parameters:**
 - **saleTypeQuoteAttachmentId** The ID of the sale type quote attachment row

**Returns:** Bool

```crmscript
NSQuoteAgent agent;
Integer saleTypeQuoteAttachmentId;
Bool res = agent.ToggleSaleTypeQuoteAttachmentDefaultIncluded(saleTypeQuoteAttachmentId);
```

