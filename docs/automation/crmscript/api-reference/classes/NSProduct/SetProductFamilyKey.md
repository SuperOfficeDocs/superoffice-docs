---
uid: crmscript_ref_NSProduct_SetProductFamilyKey
title: SetProductFamilyKey(String productFamilyKey)
intellisense: NSProduct.SetProductFamilyKey
keywords: NSProduct, GetProductFamilyKey
so.topic: reference
---

# SetProductFamilyKey(String productFamilyKey)

Either a List id to an id from a connector provided list, or, if the connection doesn't support lists, a text with the actual product family.

**Parameter:** 
 - **productFamilyKey** String

```crmscript
NSProduct thing;
String productFamilyKey;
thing.SetProductFamilyKey(productFamilyKey);
```

