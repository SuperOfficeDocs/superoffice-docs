---
uid: crmscript_ref_NSDocumentEntity_SetSale
title: SetSale(NSSale sale)
intellisense: NSDocumentEntity.SetSale
keywords: NSDocumentEntity, GetSale
so.topic: reference
---

A document may also be connected to a sale, so you see the document on the company card, on the project card and on the sale card. This does not mean however that a sale is required. May be null.

**Parameter:** 
 - **sale** NSSale

```crmscript
NSDocumentEntity thing;
NSSale sale;
thing.SetSale(sale);
```

