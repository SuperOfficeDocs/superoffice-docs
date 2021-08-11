---
uid: crmscript_ref_NSQuoteLine_GetUnitMinimumPrice
title: Float GetUnitMinimumPrice()
intellisense: NSQuoteLine.GetUnitMinimumPrice
keywords: NSQuoteLine, GetUnitMinimumPrice
so.topic: reference
---

# Float GetUnitMinimumPrice()

The minimum price this line can be sold for (to limit discounting). Will come from the connector. List price per unit must exceed the minimum price per unit.

**Returns:** Float

```crmscript
NSQuoteLine thing;
Float unitMinimumPrice  = thing.GetUnitMinimumPrice();
```

