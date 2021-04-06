---
uid: crmscript_ref_NSQuoteAlternative_GetERPDiscountAmount
title: Float GetERPDiscountAmount()
intellisense: NSQuoteAlternative.GetERPDiscountAmount
keywords: NSQuoteAlternative, GetERPDiscountAmount
so.topic: reference
---

The discount the system calculates based on customer /amount / whatever. Can be overridden by the user in the field ‘DiscountPercent’ or ‘DiscountAmount’. Both the two ‘ERPDiscountPercent’ and ‘ERPDiscountAmount’ shall be filled out. If UserValueOverride is 'None', then the ERPDiscountAmount shall be copied into DiscountAmount and ERPDiscountPercent into DiscountPercent.

**Returns:** Float


```crmscript
NSQuoteAlternative thing;
Float eRPDiscountAmount  = thing.GetERPDiscountAmount();
```


