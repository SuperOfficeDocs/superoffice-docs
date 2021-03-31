---
uid: crmscript_ref_NSQuoteAgent_AddSaleTypeQuoteAttachment
title: Integer AddSaleTypeQuoteAttachment(Integer saleTypeId, Integer documentId)
intellisense: NSQuoteAgent.AddSaleTypeQuoteAttachment
keywords: NSQuoteAgent, AddSaleTypeQuoteAttachment
so.topic: reference
---

Adds a new quote attachment document to a sale type

**Parameters:**
 - **saleTypeId** The ID of the sale type
 - **documentId** The ID of the document

**Returns:** ID of the new sale type quote attachment row

```crmscript
NSQuoteAgent agent;
Integer saleTypeId;
Integer documentId;
Integer res = agent.AddSaleTypeQuoteAttachment(saleTypeId, documentId);
```

