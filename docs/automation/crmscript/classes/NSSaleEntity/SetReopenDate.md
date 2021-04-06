---
uid: crmscript_ref_NSSaleEntity_SetReopenDate
title: SetReopenDate(DateTime reopenDate)
intellisense: NSSaleEntity.SetReopenDate
keywords: NSSaleEntity, GetReopenDate
so.topic: reference
---

Date the sale is to be reopened; valid only for status=stalled. Not necessarily the same as the nextDueDate.

**Parameter:** 
 - **reopenDate** DateTime

```crmscript
NSSaleEntity thing;
DateTime reopenDate;
thing.SetReopenDate(reopenDate);
```

