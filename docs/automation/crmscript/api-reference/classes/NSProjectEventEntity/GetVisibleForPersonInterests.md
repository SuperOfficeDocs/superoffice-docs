---
uid: crmscript_ref_NSProjectEventEntity_GetVisibleForPersonInterests
title: NSMDOListItem[] GetVisibleForPersonInterests()
intellisense: NSProjectEventEntity.GetVisibleForPersonInterests
keywords: NSProjectEventEntity, GetVisibleForPersonInterests
so.topic: reference
---

# NSMDOListItem[] GetVisibleForPersonInterests()

Array of person interests (MDO table "persint") that this event is visible for.

**Returns:** NSMDOListItem[]

```crmscript
NSProjectEventEntity thing;
NSMDOListItem[] visibleForPersonInterests  = thing.GetVisibleForPersonInterests();
```

