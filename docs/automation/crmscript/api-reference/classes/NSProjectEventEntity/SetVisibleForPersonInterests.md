---
uid: crmscript_ref_NSProjectEventEntity_SetVisibleForPersonInterests
title: SetVisibleForPersonInterests(NSMDOListItem[] visibleForPersonInterests)
intellisense: NSProjectEventEntity.SetVisibleForPersonInterests
keywords: NSProjectEventEntity, GetVisibleForPersonInterests
so.topic: reference
---

Array of person interests (MDO table "persint") that this event is visible for.

**Parameter:** 
 - **visibleForPersonInterests** NSMDOListItem[]

```crmscript
NSProjectEventEntity thing;
NSMDOListItem[] visibleForPersonInterests;
thing.SetVisibleForPersonInterests(visibleForPersonInterests);
```

