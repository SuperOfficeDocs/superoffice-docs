---
uid: crmscript_ref_NSTicketPriorityEntity_GetNonDates
title: DateTime[] GetNonDates()
intellisense: NSTicketPriorityEntity.GetNonDates
keywords: NSTicketPriorityEntity, GetNonDates
so.topic: reference
---

# DateTime[] GetNonDates()

Dates which the escalation time should not be running. Note that only the day of the year (day and month) is used. So the year and time part is not used even if this is a DateTime

**Returns:** DateTime[]

```crmscript
NSTicketPriorityEntity thing;
DateTime[] nonDates  = thing.GetNonDates();
```

