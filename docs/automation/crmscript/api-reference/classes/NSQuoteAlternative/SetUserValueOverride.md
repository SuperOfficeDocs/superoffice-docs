---
uid: crmscript_ref_NSQuoteAlternative_SetUserValueOverride
title: SetUserValueOverride(Integer userValueOverride)
intellisense: NSQuoteAlternative.SetUserValueOverride
keywords: NSQuoteAlternative, GetUserValueOverride
so.topic: reference
---

Has the pre-calculated (from ERP) price information been overridden, and how. If the user has filled out the discountpercentage field, then the UserValueOverride field is set to OverridePercent. (The DiscountAmount, EarningPercent, EarningAmount and TotalPrice fields are calculated based on the discountPercent.)

**Parameter:** 
 - **userValueOverride** Integer
     - Enum: 0 = None 
     - Enum: 1 = Total 
     - Enum: 2 = DiscountPercent 
     - Enum: 3 = DiscountAmount 
     - Enum: 4 = EarningPercent 
     - Enum: 5 = EarningAmount 

```crmscript
NSQuoteAlternative thing;
Integer userValueOverride;
thing.SetUserValueOverride(userValueOverride);
```

