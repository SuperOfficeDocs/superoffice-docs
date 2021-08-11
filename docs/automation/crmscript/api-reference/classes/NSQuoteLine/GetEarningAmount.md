---
uid: crmscript_ref_NSQuoteLine_GetEarningAmount
title: Float GetEarningAmount()
intellisense: NSQuoteLine.GetEarningAmount
keywords: NSQuoteLine, GetEarningAmount
so.topic: reference
---

# Float GetEarningAmount()

The earning, in whatever currency the sale is in. Both ‘EarningAmount and ‘EarningPercent shall be filled out, but the UserValueOverride field must be set to the field the user actually changed last.

**Returns:** Float

```crmscript
NSQuoteLine thing;
Float earningAmount  = thing.GetEarningAmount();
```

