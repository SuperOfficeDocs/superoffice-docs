---
uid: crmscript_ref_NSTypicalSearches_SetMasterVersion
title: SetMasterVersion(Integer masterVersion)
intellisense: NSTypicalSearches.SetMasterVersion
keywords: NSTypicalSearches, GetMasterVersion
so.topic: reference
---

# SetMasterVersion(Integer masterVersion)

The master version number in this update, at least the highest of those in the searches, but can be higher to force an update (and delete of missing elements)

**Parameter:** 
 - **masterVersion** Integer

```crmscript
NSTypicalSearches thing;
Integer masterVersion;
thing.SetMasterVersion(masterVersion);
```

