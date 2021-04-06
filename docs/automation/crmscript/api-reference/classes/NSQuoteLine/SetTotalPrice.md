---
uid: crmscript_ref_NSQuoteLine_SetTotalPrice
title: SetTotalPrice(Float totalPrice)
intellisense: NSQuoteLine.SetTotalPrice
keywords: NSQuoteLine, GetTotalPrice
so.topic: reference
---

TotalPrice  = SubTotal - DiscountAmount or TotalPrice = (UnitCost * Quantity) + EarningAmount, according to what the user changed last.

**Parameter:** 
 - **totalPrice** Float

```crmscript
NSQuoteLine thing;
Float totalPrice;
thing.SetTotalPrice(totalPrice);
```

