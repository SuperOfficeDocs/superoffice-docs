---
uid: crmscript_ref_NSProduct_SetUnitListPrice
title: SetUnitListPrice(Float unitListPrice)
intellisense: NSProduct.SetUnitListPrice
keywords: NSProduct, GetUnitListPrice
so.topic: reference
---

(Basic Price, normal price, standard price.) This is the basic price from which the discount is computed from. The ListPrice will stay the same even when a larger amount is ordered.

**Parameter:** 
 - **unitListPrice** Float

```crmscript
NSProduct thing;
Float unitListPrice;
thing.SetUnitListPrice(unitListPrice);
```

