---
uid: crmscript_ref_NSTypicalSearches_GetDeleteLeftovers
title: Bool GetDeleteLeftovers()
intellisense: NSTypicalSearches.GetDeleteLeftovers
keywords: NSTypicalSearches, GetDeleteLeftovers
so.topic: reference
---

# Bool GetDeleteLeftovers()

If true, then any TypicalSearch records in the database that are NOT referenced in this call, should be deleted

**Returns:** Bool

```crmscript
NSTypicalSearches thing;
Bool deleteLeftovers  = thing.GetDeleteLeftovers();
```

