---
title: crmscript_ref_NSQuoteLine_GetUserValueOverride
description: NSQuoteLine.GetUserValueOverride()
intellisense: NSQuoteLine.GetUserValueOverride
keywords: GetUserValueOverride()
so.topic: reference
---

Has the pre-calculated (from ERP) price information been overridden, and how. If the user has filled out the discountpercentage field, then the UserValueOverride field is set to OverridePercent. (The DiscountAmount, EarningPercent, EarningAmount and TotalPrice fields are calculated based on the DiscountPercent.)

* None=0
* Total=1
* DiscountPercent=2
* DiscountAmount=3
* EarningPercent=4
* EarningAmount=5

* **Returns:** Integer
