---
uid: crmscript_ref_NSProduct_GetInAssortment
title: Bool GetInAssortment()
intellisense: NSProduct.GetInAssortment
keywords: NSProduct, GetInAssortment
so.topic: reference
---

True for products that should currently be offered, false when the product is discontinued and should not ordinarily be offered. When false the product no longer appears in search results.

**Returns:** Bool


```crmscript
NSProduct thing;
Bool inAssortment  = thing.GetInAssortment();
```


