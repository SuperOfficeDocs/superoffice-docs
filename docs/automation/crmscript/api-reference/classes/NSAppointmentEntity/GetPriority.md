---
uid: crmscript_ref_NSAppointmentEntity_GetPriority
title: Priority GetPriority()
intellisense: NSAppointmentEntity.GetPriority
keywords: NSAppointmentEntity, GetPriority
so.topic: reference
---

It's possible to give appointments different priorities. All the different priority types are saved in the priority table, and edited from the Admin. Client. An appointment does not require a priority.

**Returns:** Priority


```crmscript
NSAppointmentEntity thing;
Priority priority  = thing.GetPriority();
```


