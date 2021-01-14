---
title: NSQuoteVersionValidated ValidateQuoteVersion(Integer quoteVersionId, Integer action)
path: /EJScript/Classes/NSQuoteAgent/Member functions/NSQuoteVersionValidated ValidateQuoteVersion(Integer p_0, Integer p_1)
intellisense: 1
classref: 1
sortOrder: 6028
keywords: ValidateQuoteVersion(Integer,Integer)
---


When the user changes one or more values in a quoteline or a quoteAlternative, the connector gets to change the QuoteLines and the alternative, for instance calculate VAT. ValidateQuoteVersion shall be called when the user presses the validate button, presses the send button or closes the quote dialog. RecalculateQuoteAlternative should typically validate all alternatives, set values in extrafields, and set the state in the version.



* **quoteVersionId:** The version to be validated
* **action:** The action, if any, related to the validate call, like PlaceOrder or SendQuote
* **Returns:** The updated quote version.


