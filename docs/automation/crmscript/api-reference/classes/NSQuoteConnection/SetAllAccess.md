---
uid: crmscript_ref_NSQuoteConnection_SetAllAccess
title: SetAllAccess(Bool allAccess)
intellisense: NSQuoteConnection.SetAllAccess
keywords: NSQuoteConnection, GetAllAccess
so.topic: reference
---

# SetAllAccess(Bool allAccess)

Is this connection accessible to everyone?  If not, then the QuoteConnectionAccess table tells us who can access it.

**Parameter:** 
 - **allAccess** Bool

```crmscript
NSQuoteConnection thing;
Bool allAccess;
thing.SetAllAccess(allAccess);
```

