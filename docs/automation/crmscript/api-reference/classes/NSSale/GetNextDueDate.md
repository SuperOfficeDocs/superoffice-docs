---
uid: crmscript_ref_NSSale_GetNextDueDate
title: DateTime GetNextDueDate()
intellisense: NSSale.GetNextDueDate
keywords: NSSale, GetNextDueDate
so.topic: reference
---

Next due date, this is a denormalization of 'closest future activity date, or most recent if no future activities'. Maintained by the system, but very convenient for searching.

**Returns:** DateTime


```crmscript
NSSale thing;
DateTime nextDueDate  = thing.GetNextDueDate();
```


