---
uid: crmscript_ref_NSQuote_GetAcceptedQuoteAlternativeId
title: Integer GetAcceptedQuoteAlternativeId()
intellisense: NSQuote.GetAcceptedQuoteAlternativeId
keywords: NSQuote, GetAcceptedQuoteAlternativeId
so.topic: reference
---

# Integer GetAcceptedQuoteAlternativeId()

The primary key of the Quote Alternative which was finally accepted by the customer. Set when the user is marking a quote as accepted.

**Returns:** Integer

```crmscript
NSQuote thing;
Integer acceptedQuoteAlternativeId  = thing.GetAcceptedQuoteAlternativeId();
```

