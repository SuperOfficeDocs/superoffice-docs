---
uid: crmscript_ref_NSProjectEventEntity_SetVisibleForPersonInterests
title: SetVisibleForPersonInterests(MDOListItem[] visibleForPersonInterests)
intellisense: NSProjectEventEntity.SetVisibleForPersonInterests
keywords: NSProjectEventEntity, GetVisibleForPersonInterests
so.topic: reference
---

Array of person interests (MDO table "persint") that this event is visible for.

**Parameter:** 
 - **visibleForPersonInterests** MDOListItem[]

```crmscript
NSProjectEventEntity thing;
MDOListItem[] visibleForPersonInterests;
thing.SetVisibleForPersonInterests(visibleForPersonInterests);
```

