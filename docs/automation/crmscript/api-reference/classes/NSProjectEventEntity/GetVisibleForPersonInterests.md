---
uid: crmscript_ref_NSProjectEventEntity_GetVisibleForPersonInterests
title: MDOListItem[] GetVisibleForPersonInterests()
intellisense: NSProjectEventEntity.GetVisibleForPersonInterests
keywords: NSProjectEventEntity, GetVisibleForPersonInterests
so.topic: reference
---

Array of person interests (MDO table "persint") that this event is visible for.

**Returns:** MDOListItem[]


```crmscript
NSProjectEventEntity thing;
MDOListItem[] visibleForPersonInterests  = thing.GetVisibleForPersonInterests();
```


