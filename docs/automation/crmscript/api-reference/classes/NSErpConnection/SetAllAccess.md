---
uid: crmscript_ref_NSErpConnection_SetAllAccess
title: SetAllAccess(Bool allAccess)
intellisense: NSErpConnection.SetAllAccess
keywords: NSErpConnection, GetAllAccess
so.topic: reference
---

Is this connection accessible to everyone?  If not, then the ErpConnectionAccess table tells us who can access it

**Parameter:** 
 - **allAccess** Bool

```crmscript
NSErpConnection thing;
Bool allAccess;
thing.SetAllAccess(allAccess);
```

