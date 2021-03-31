---
title: crmscript_ref_NSQuoteAgent_RecalculateQuoteAlternative
description: QuoteAlternativeRecalculated RecalculateQuoteAlternative(Integer quoteAlternative)
intellisense: NSQuoteAgent.RecalculateQuoteAlternative
keywords: NSQuoteAgent,RecalculateQuoteAlternative
so.topic: reference
---

When the user changes one or more values in a quoteline or a quoteAlternative, the connector gets to change the QuoteLines and the alternative, for instance calculate VAT. RecalculateQuoteAlternative shall be called when the user changes any of the following fields: Quantity, DiscountAmount, DiscountPercent, listprice (if allowed). RecalculateQuoteAlternative will calculate the TotalPrice and the VAT (if possible) for the lines and the alternative.

**Parameters:**
 - **quoteAlternative** The alternative to be recalculated

**Returns:** The updated quote version.

```crmscript
NSQuoteAgent agent;
Integer quoteAlternative;
QuoteAlternativeRecalculated res = agent.RecalculateQuoteAlternative(quoteAlternative);
```

