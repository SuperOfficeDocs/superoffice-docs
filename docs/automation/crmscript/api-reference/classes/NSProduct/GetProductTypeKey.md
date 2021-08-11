---
uid: crmscript_ref_NSProduct_GetProductTypeKey
title: String GetProductTypeKey()
intellisense: NSProduct.GetProductTypeKey
keywords: NSProduct, GetProductTypeKey
so.topic: reference
---

# String GetProductTypeKey()

Either a List id to an id from a connector provided list, or, if the connection doesn’t support lists, a text with the actual product type.

**Returns:** String

```crmscript
NSProduct thing;
String productTypeKey  = thing.GetProductTypeKey();
```

