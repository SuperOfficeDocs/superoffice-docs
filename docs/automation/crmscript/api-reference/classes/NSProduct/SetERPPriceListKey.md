---
uid: crmscript_ref_NSProduct_SetERPPriceListKey
title: SetERPPriceListKey(String eRPPriceListKey)
intellisense: NSProduct.SetERPPriceListKey
keywords: NSProduct, GetERPPriceListKey
so.topic: reference
---

# SetERPPriceListKey(String eRPPriceListKey)

Foreign key to the price list that this product is a part of, or the primary key of the pricelist if this is a built-in pricelist.

**Parameter:** 
 - **eRPPriceListKey** String

```crmscript
NSProduct thing;
String eRPPriceListKey;
thing.SetERPPriceListKey(eRPPriceListKey);
```

