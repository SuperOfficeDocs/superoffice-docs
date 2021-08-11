---
uid: crmscript_ref_NSProduct_GetProductFamilyKey
title: String GetProductFamilyKey()
intellisense: NSProduct.GetProductFamilyKey
keywords: NSProduct, GetProductFamilyKey
so.topic: reference
---

# String GetProductFamilyKey()

Either a List id to an id from a connector provided list, or, if the connection doesn't support lists, a text with the actual product family.

**Returns:** String

```crmscript
NSProduct thing;
String productFamilyKey  = thing.GetProductFamilyKey();
```

