---
uid: crmscript_ref_NSQuoteLine_SetEarningPercent
title: SetEarningPercent(Float earningPercent)
intellisense: NSQuoteLine.SetEarningPercent
keywords: NSQuoteLine, GetEarningPercent
so.topic: reference
---

# SetEarningPercent(Float earningPercent)

The earning, in percent. Both ‘EarningAmount and ‘EarningPercent shall be filled out, but the UserValueOverride field must be set to the field the user actually changed last. The Percentage is given in integer form, i.e. ‘12%’ is represented as ‘12’.

**Parameter:** 
 - **earningPercent** Float

```crmscript
NSQuoteLine thing;
Float earningPercent;
thing.SetEarningPercent(earningPercent);
```

