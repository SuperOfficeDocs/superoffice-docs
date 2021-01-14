---
title: NSQuoteAlternativeRecalculated RecalculateQuoteAlternative(Integer quoteAlternative)
path: /EJScript/Classes/NSQuoteAgent/Member functions/NSQuoteAlternativeRecalculated RecalculateQuoteAlternative(Integer p_0)
intellisense: 1
classref: 1
keywords: RecalculateQuoteAlternative(Integer)
---


When the user changes one or more values in a quoteline or a quoteAlternative, the connector gets to change the QuoteLines and the alternative, for instance calculate VAT. RecalculateQuoteAlternative shall be called when the user changes any of the following fields: Quantity, DiscountAmount, DiscountPercent, listprice (if allowed). RecalculateQuoteAlternative will calculate the TotalPrice and the VAT (if possible) for the lines and the alternative.



* **quoteAlternative:** The alternative to be recalculated
* **Returns:** The updated quote version.


