---
uid: crmscript_ref_NSQuoteLine_GetEarningPercent
title: Float GetEarningPercent()
intellisense: NSQuoteLine.GetEarningPercent
keywords: NSQuoteLine, GetEarningPercent
so.topic: reference
---

The earning, in percent. Both ‘EarningAmount and ‘EarningPercent shall be filled out, but the UserValueOverride field must be set to the field the user actually changed last. The Percentage is given in integer form, i.e. ‘12%’ is represented as ‘12’.

**Returns:** Float


```crmscript
NSQuoteLine thing;
Float earningPercent  = thing.GetEarningPercent();
```


