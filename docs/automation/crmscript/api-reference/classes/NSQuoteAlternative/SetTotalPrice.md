---
uid: crmscript_ref_NSQuoteAlternative_SetTotalPrice
title: SetTotalPrice(Float totalPrice)
intellisense: NSQuoteAlternative.SetTotalPrice
keywords: NSQuoteAlternative, GetTotalPrice
so.topic: reference
---

Sum of the QuoteLines.TotalPrice - AlternativeDiscount or QuoteLines.TotalCost + Earning based on what, if anything, the user has entered last. Shall be calculated by the connector.

**Parameter:** 
 - **totalPrice** Float

```crmscript
NSQuoteAlternative thing;
Float totalPrice;
thing.SetTotalPrice(totalPrice);
```

