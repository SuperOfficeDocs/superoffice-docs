---
uid: crmscript_ref_NSQuoteAlternative_GetERPDiscountPercent
title: Float GetERPDiscountPercent()
intellisense: NSQuoteAlternative.GetERPDiscountPercent
keywords: NSQuoteAlternative, GetERPDiscountPercent
so.topic: reference
---

The discount the system calculates based on customer /amount / whatever. Can be overridden by the sales rep in the field ‘DiscountPercent’ or ‘DiscountAmount’. Both the two ‘ERPDiscountPercent’ and ‘ERPDiscountAmount’ shall be filled out. If UserValueOverride is 'None', then the ERPDiscountAmount shall be copied into DiscountAmount and ERPDiscountPercent into DiscountPercent. The Percentage is given in integer form, i.e. ‘12%’ is represented as ‘12’.

**Returns:** Float


```crmscript
NSQuoteAlternative thing;
Float eRPDiscountPercent  = thing.GetERPDiscountPercent();
```


