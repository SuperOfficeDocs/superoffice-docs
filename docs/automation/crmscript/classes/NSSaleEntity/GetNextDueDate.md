---
uid: crmscript_ref_NSSaleEntity_GetNextDueDate
title: DateTime GetNextDueDate()
intellisense: NSSaleEntity.GetNextDueDate
keywords: NSSaleEntity, GetNextDueDate
so.topic: reference
---

Next due date, this is a denormalization of 'closest future activity date, or most recent if no future activities'. Maintained by the system, but very convenient for searching.

**Returns:** DateTime


```crmscript
NSSaleEntity thing;
DateTime nextDueDate  = thing.GetNextDueDate();
```


