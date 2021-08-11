---
uid: crmscript_ref_NSDocumentEntity_GetSale
title: NSSale GetSale()
intellisense: NSDocumentEntity.GetSale
keywords: NSDocumentEntity, GetSale
so.topic: reference
---

# NSSale GetSale()

A document may also be connected to a sale, so you see the document on the company card, on the project card and on the sale card. This does not mean however that a sale is required. May be null.

**Returns:** NSSale

```crmscript
NSDocumentEntity thing;
NSSale sale  = thing.GetSale();
```

