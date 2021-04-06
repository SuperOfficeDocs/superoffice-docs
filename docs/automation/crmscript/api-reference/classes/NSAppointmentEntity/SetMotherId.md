---
uid: crmscript_ref_NSAppointmentEntity_SetMotherId
title: SetMotherId(Integer motherId)
intellisense: NSAppointmentEntity.SetMotherId
keywords: NSAppointmentEntity, GetMotherId
so.topic: reference
---

ID of mother appointment; self if booking master, master ID if booking slave, 0 if normal appointment. However, if 0 and assoc_id != reg_id then this is an assigned appointment, indicated vt type = kBooking

**Parameter:** 
 - **motherId** Integer

```crmscript
NSAppointmentEntity thing;
Integer motherId;
thing.SetMotherId(motherId);
```

