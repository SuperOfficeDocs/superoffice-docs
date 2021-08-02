---
uid: crmscript_ref_NSDocumentAgent_GetSaleDocuments
title: NSDocument[] GetSaleDocuments(Integer saleId)
intellisense: NSDocumentAgent.GetSaleDocuments
keywords: NSDocumentAgent, GetSaleDocuments
so.topic: reference
---

Get all documents that are linked to the sale. I.e. the documents that are listed in the sale dialog.

**Parameters:**
 - **saleId** The sale id.

**Returns:** NSDocument[]

```crmscript
NSDocumentAgent agent;
Integer saleId;
NSDocument[] res = agent.GetSaleDocuments(saleId);
```

