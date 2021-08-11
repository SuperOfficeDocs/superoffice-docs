---
uid: crmscript_ref_NSErpSyncFieldMapping_SetAlreadyMapped
title: SetAlreadyMapped(Bool alreadyMapped)
intellisense: NSErpSyncFieldMapping.SetAlreadyMapped
keywords: NSErpSyncFieldMapping, GetAlreadyMapped
so.topic: reference
---

# SetAlreadyMapped(Bool alreadyMapped)

Is this ERPField already mapped in some other connection? If so, then it cannot be one-way mapped TO SuperOffice here

**Parameter:** 
 - **alreadyMapped** Bool

```crmscript
NSErpSyncFieldMapping thing;
Bool alreadyMapped;
thing.SetAlreadyMapped(alreadyMapped);
```

