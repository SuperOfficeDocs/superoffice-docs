---
uid: crmscript_ref_NSAppointmentEntity_GetPriority
title: NSPriority GetPriority()
intellisense: NSAppointmentEntity.GetPriority
keywords: NSAppointmentEntity, GetPriority
so.topic: reference
---

It's possible to give appointments different priorities. All the different priority types are saved in the priority table, and edited from the Admin. Client. An appointment does not require a priority.

**Returns:** NSPriority


```crmscript
NSAppointmentEntity thing;
NSPriority priority  = thing.GetPriority();
```


