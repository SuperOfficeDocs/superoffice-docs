---
uid: crmscript_ref_NSAppointment_GetPrivate
title: AppointmentPrivate GetPrivate()
intellisense: NSAppointment.GetPrivate
keywords: NSAppointment, GetPrivate
so.topic: reference
---

# AppointmentPrivate GetPrivate()

Obsolete, but still maintained field for appointment privacy; denormalization of visiblefor status

**Returns:** AppointmentPrivate

     - Enum: 0 = Public 
     - Enum: 1 = PrivateUser 
     - Enum: 2 = PrivateGroup 

```crmscript
NSAppointment thing;
AppointmentPrivate private  = thing.GetPrivate();
```

