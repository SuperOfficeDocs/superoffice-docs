---
uid: crmscript_ref_NSTypicalSearches_GetMasterVersion
title: Integer GetMasterVersion()
intellisense: NSTypicalSearches.GetMasterVersion
keywords: NSTypicalSearches, GetMasterVersion
so.topic: reference
---

# Integer GetMasterVersion()

The master version number in this update, at least the highest of those in the searches, but can be higher to force an update (and delete of missing elements)

**Returns:** Integer

```crmscript
NSTypicalSearches thing;
Integer masterVersion  = thing.GetMasterVersion();
```

