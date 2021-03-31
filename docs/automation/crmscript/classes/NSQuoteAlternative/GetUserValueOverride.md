---
title: crmscript_ref_NSQuoteAlternative_GetUserValueOverride
description: ValueOverride NSQuoteAlternative.GetUserValueOverride()
intellisense: NSQuoteAlternative.GetUserValueOverride
keywords: NSQuoteAlternative, GetUserValueOverride
so.topic: reference
---

Has the pre-calculated (from ERP) price information been overridden, and how. If the user has filled out the discountpercentage field, then the UserValueOverride field is set to OverridePercent. (The DiscountAmount, EarningPercent, EarningAmount and TotalPrice fields are calculated based on the discountPercent.)

**Returns:** ValueOverride

     - Enum: 0 = None 
     - Enum: 1 = Total 
     - Enum: 2 = DiscountPercent 
     - Enum: 3 = DiscountAmount 
     - Enum: 4 = EarningPercent 
     - Enum: 5 = EarningAmount 

