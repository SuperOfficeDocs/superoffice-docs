---
uid: crmscript_ref_NSAppointmentEntity_SetPriority
title: SetPriority(NSPriority priority)
intellisense: NSAppointmentEntity.SetPriority
keywords: NSAppointmentEntity, GetPriority
so.topic: reference
---

# SetPriority(NSPriority priority)

It's possible to give appointments different priorities. All the different priority types are saved in the priority table, and edited from the Admin. Client. An appointment does not require a priority.

**Parameter:** 
 - **priority** NSPriority

```crmscript
NSAppointmentEntity thing;
NSPriority priority;
thing.SetPriority(priority);
```

