---
title: crmscript_ref_NSQuoteAgent_ValidateQuoteVersion_Integer_p_0_Integer_p_1
description: NSQuoteAgent.ValidateQuoteVersion(Integer p_0, Integer p_1)
intellisense: NSQuoteAgent.ValidateQuoteVersion
keywords: ValidateQuoteVersion(Integer,Integer)
so.topic: reference
---


When the user changes one or more values in a quoteline or a quoteAlternative, the connector gets to change the QuoteLines and the alternative, for instance calculate VAT. ValidateQuoteVersion shall be called when the user presses the validate button, presses the send button or closes the quote dialog. RecalculateQuoteAlternative should typically validate all alternatives, set values in extrafields, and set the state in the version.



* **quoteVersionId:** The version to be validated
* **action:** The action, if any, related to the validate call, like PlaceOrder or SendQuote
* **Returns:** The updated quote version.


