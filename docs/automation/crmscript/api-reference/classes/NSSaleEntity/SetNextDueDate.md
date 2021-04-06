---
uid: crmscript_ref_NSSaleEntity_SetNextDueDate
title: SetNextDueDate(DateTime nextDueDate)
intellisense: NSSaleEntity.SetNextDueDate
keywords: NSSaleEntity, GetNextDueDate
so.topic: reference
---

Next due date, this is a denormalization of 'closest future activity date, or most recent if no future activities'. Maintained by the system, but very convenient for searching.

**Parameter:** 
 - **nextDueDate** DateTime

```crmscript
NSSaleEntity thing;
DateTime nextDueDate;
thing.SetNextDueDate(nextDueDate);
```

