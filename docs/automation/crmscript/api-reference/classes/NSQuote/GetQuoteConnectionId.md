---
uid: crmscript_ref_NSQuote_GetQuoteConnectionId
title: Integer GetQuoteConnectionId()
intellisense: NSQuote.GetQuoteConnectionId
keywords: NSQuote, GetQuoteConnectionId
so.topic: reference
---

The connection in the CRM system to where this quote came from. Identifies the ERP connection used for this quote. Each quote is bound to one and only one connection.

**Returns:** Integer


```crmscript
NSQuote thing;
Integer quoteConnectionId  = thing.GetQuoteConnectionId();
```


