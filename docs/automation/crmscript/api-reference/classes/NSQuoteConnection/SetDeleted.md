---
uid: crmscript_ref_NSQuoteConnection_SetDeleted
title: SetDeleted(Bool deleted)
intellisense: NSQuoteConnection.SetDeleted
keywords: NSQuoteConnection, GetDeleted
so.topic: reference
---

# SetDeleted(Bool deleted)

If set, then this is a row that has been 'deleted'; we do not physically delete rows to avoid disaster.

**Parameter:** 
 - **deleted** Bool

```crmscript
NSQuoteConnection thing;
Bool deleted;
thing.SetDeleted(deleted);
```

