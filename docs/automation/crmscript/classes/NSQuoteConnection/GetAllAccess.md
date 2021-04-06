---
uid: crmscript_ref_NSQuoteConnection_GetAllAccess
title: Bool GetAllAccess()
intellisense: NSQuoteConnection.GetAllAccess
keywords: NSQuoteConnection, GetAllAccess
so.topic: reference
---

Is this connection accessible to everyone?  If not, then the QuoteConnectionAccess table tells us who can access it.

**Returns:** Bool


```crmscript
NSQuoteConnection thing;
Bool allAccess  = thing.GetAllAccess();
```


