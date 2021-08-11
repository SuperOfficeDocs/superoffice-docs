---
uid: crmscript_ref_NSProduct_GetUnitListPrice
title: Float GetUnitListPrice()
intellisense: NSProduct.GetUnitListPrice
keywords: NSProduct, GetUnitListPrice
so.topic: reference
---

# Float GetUnitListPrice()

(Basic Price, normal price, standard price.) This is the basic price from which the discount is computed from. The ListPrice will stay the same even when a larger amount is ordered.

**Returns:** Float

```crmscript
NSProduct thing;
Float unitListPrice  = thing.GetUnitListPrice();
```

