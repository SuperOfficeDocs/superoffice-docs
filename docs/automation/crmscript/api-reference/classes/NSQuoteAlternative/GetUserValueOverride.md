---
uid: crmscript_ref_NSQuoteAlternative_GetUserValueOverride
title: Integer GetUserValueOverride()
intellisense: NSQuoteAlternative.GetUserValueOverride
keywords: NSQuoteAlternative, GetUserValueOverride
so.topic: reference
---

# Integer GetUserValueOverride()

Has the pre-calculated (from ERP) price information been overridden, and how. If the user has filled out the discountpercentage field, then the UserValueOverride field is set to OverridePercent. (The DiscountAmount, EarningPercent, EarningAmount and TotalPrice fields are calculated based on the discountPercent.)

**Returns:** Integer

     - Enum: 0 = None 
     - Enum: 1 = Total 
     - Enum: 2 = DiscountPercent 
     - Enum: 3 = DiscountAmount 
     - Enum: 4 = EarningPercent 
     - Enum: 5 = EarningAmount 

```crmscript
NSQuoteAlternative thing;
Integer userValueOverride  = thing.GetUserValueOverride();
```

