---
uid: crmscript_ref_NSQuoteAlternative_GetTotalPrice
title: Float GetTotalPrice()
intellisense: NSQuoteAlternative.GetTotalPrice
keywords: NSQuoteAlternative, GetTotalPrice
so.topic: reference
---

# Float GetTotalPrice()

Sum of the QuoteLines.TotalPrice - AlternativeDiscount or QuoteLines.TotalCost + Earning based on what, if anything, the user has entered last. Shall be calculated by the connector.

**Returns:** Float

```crmscript
NSQuoteAlternative thing;
Float totalPrice  = thing.GetTotalPrice();
```

