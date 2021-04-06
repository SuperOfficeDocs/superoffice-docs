---
uid: crmscript_ref_NSQuoteLine_GetERPDiscountAmount
title: Float GetERPDiscountAmount()
intellisense: NSQuoteLine.GetERPDiscountAmount
keywords: NSQuoteLine, GetERPDiscountAmount
so.topic: reference
---

The discount the system calculates based on customer / quantity / whatever. Can be overrided by the salesman in the field 'DiscountPercent' or 'DiscountAmount'. If UserValueOverride is set to ‘None’ then the value is copied to DiscountAmount. Both fields ERPDiscountPercent and ERPDiscountAmount will be filled out.

**Returns:** Float


```crmscript
NSQuoteLine thing;
Float eRPDiscountAmount  = thing.GetERPDiscountAmount();
```


