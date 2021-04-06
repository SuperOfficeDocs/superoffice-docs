---
uid: crmscript_ref_NSProduct_SetInAssortment
title: SetInAssortment(Bool inAssortment)
intellisense: NSProduct.SetInAssortment
keywords: NSProduct, GetInAssortment
so.topic: reference
---

True for products that should currently be offered, false when the product is discontinued and should not ordinarily be offered. When false the product no longer appears in search results.

**Parameter:** 
 - **inAssortment** Bool

```crmscript
NSProduct thing;
Bool inAssortment;
thing.SetInAssortment(inAssortment);
```

