---
uid: crmscript_ref_NSAppointmentEntity_GetMotherId
title: Integer GetMotherId()
intellisense: NSAppointmentEntity.GetMotherId
keywords: NSAppointmentEntity, GetMotherId
so.topic: reference
---

ID of mother appointment; self if booking master, master ID if booking slave, 0 if normal appointment. However, if 0 and assoc_id != reg_id then this is an assigned appointment, indicated vt type = kBooking

**Returns:** Integer


```crmscript
NSAppointmentEntity thing;
Integer motherId  = thing.GetMotherId();
```


