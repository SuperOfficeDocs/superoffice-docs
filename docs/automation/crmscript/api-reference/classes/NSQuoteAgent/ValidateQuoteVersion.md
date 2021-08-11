---
uid: crmscript_ref_NSQuoteAgent_ValidateQuoteVersion
title: NSQuoteVersionValidated ValidateQuoteVersion(Integer quoteVersionId, Integer action)
intellisense: NSQuoteAgent.ValidateQuoteVersion
keywords: NSQuoteAgent, ValidateQuoteVersion
so.topic: reference
---

# NSQuoteVersionValidated ValidateQuoteVersion(Integer quoteVersionId, Integer action)

When the user changes one or more values in a quoteline or a quoteAlternative, the connector gets to change the QuoteLines and the alternative, for instance calculate VAT. ValidateQuoteVersion shall be called when the user presses the validate button, presses the send button or closes the quote dialog. RecalculateQuoteAlternative should typically validate all alternatives, set values in extrafields, and set the state in the version.

**Parameters:**
 - **quoteVersionId** The version to be validated
 - **action** The action, if any, related to the validate call, like PlaceOrder or SendQuote
     - Enum: 0 = None 
     - Enum: 1 = ValidateVersion 
     - Enum: 2 = Edit 
     - Enum: 3 = Send 
     - Enum: 4 = Approve 
     - Enum: 5 = Reject 
     - Enum: 7 = ValidateVersionAndSendIfPossible 
     - Enum: 8 = ValidateVersionAndPlaceOrderIfPossible 
     - Enum: 9 = CloneVersion 
     - Enum: 10 = SendConfirmation 
     - Enum: 11 = GetOrderState 
     - Enum: 12 = UpdatePrices 

**Returns:** NSQuoteVersionValidated

```crmscript
NSQuoteAgent agent;
Integer quoteVersionId;
Integer action;
NSQuoteVersionValidated res = agent.ValidateQuoteVersion(quoteVersionId, action);
```

