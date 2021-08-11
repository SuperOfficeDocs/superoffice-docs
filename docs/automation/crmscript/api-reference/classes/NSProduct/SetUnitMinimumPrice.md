---
uid: crmscript_ref_NSProduct_SetUnitMinimumPrice
title: SetUnitMinimumPrice(Float unitMinimumPrice)
intellisense: NSProduct.SetUnitMinimumPrice
keywords: NSProduct, GetUnitMinimumPrice
so.topic: reference
---

# SetUnitMinimumPrice(Float unitMinimumPrice)

The minimum price this salesman can offer to his customer. This might be cost price if there is no policy. Might not be given, use Decimal.MinValue to signal this.

**Parameter:** 
 - **unitMinimumPrice** Float

```crmscript
NSProduct thing;
Float unitMinimumPrice;
thing.SetUnitMinimumPrice(unitMinimumPrice);
```

