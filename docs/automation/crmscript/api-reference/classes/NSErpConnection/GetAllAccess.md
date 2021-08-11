---
uid: crmscript_ref_NSErpConnection_GetAllAccess
title: Bool GetAllAccess()
intellisense: NSErpConnection.GetAllAccess
keywords: NSErpConnection, GetAllAccess
so.topic: reference
---

# Bool GetAllAccess()

Is this connection accessible to everyone?  If not, then the ErpConnectionAccess table tells us who can access it

**Returns:** Bool

```crmscript
NSErpConnection thing;
Bool allAccess  = thing.GetAllAccess();
```

