---
uid: crmscript_ref_NSProduct_GetERPPriceListKey
title: String GetERPPriceListKey()
intellisense: NSProduct.GetERPPriceListKey
keywords: NSProduct, GetERPPriceListKey
so.topic: reference
---

# String GetERPPriceListKey()

Foreign key to the price list that this product is a part of, or the primary key of the pricelist if this is a built-in pricelist.

**Returns:** String

```crmscript
NSProduct thing;
String eRPPriceListKey  = thing.GetERPPriceListKey();
```

