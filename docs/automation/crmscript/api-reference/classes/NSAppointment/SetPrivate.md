---
uid: crmscript_ref_NSAppointment_SetPrivate
title: SetPrivate(AppointmentPrivate private)
intellisense: NSAppointment.SetPrivate
keywords: NSAppointment, GetPrivate
so.topic: reference
---

# SetPrivate(AppointmentPrivate private)

Obsolete, but still maintained field for appointment privacy; denormalization of visiblefor status

**Parameter:** 
 - **private** AppointmentPrivate
     - Enum: 0 = Public 
     - Enum: 1 = PrivateUser 
     - Enum: 2 = PrivateGroup 

```crmscript
NSAppointment thing;
AppointmentPrivate private;
thing.SetPrivate(private);
```

