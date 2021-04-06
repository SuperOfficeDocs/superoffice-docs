---
uid: crmscript_ref_NSProduct_GetUnitMinimumPrice
title: Float GetUnitMinimumPrice()
intellisense: NSProduct.GetUnitMinimumPrice
keywords: NSProduct, GetUnitMinimumPrice
so.topic: reference
---

The minimum price this salesman can offer to his customer. This might be cost price if there is no policy. Might not be given, use Decimal.MinValue to signal this.

**Returns:** Float


```crmscript
NSProduct thing;
Float unitMinimumPrice  = thing.GetUnitMinimumPrice();
```


