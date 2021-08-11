---
uid: crmscript_ref_NSAppointment_GetMotherId
title: Integer GetMotherId()
intellisense: NSAppointment.GetMotherId
keywords: NSAppointment, GetMotherId
so.topic: reference
---

# Integer GetMotherId()

ID of mother appointment; self if booking master, master ID if booking slave, 0 if normal appointment. However, if 0 and assoc_id != reg_id then this is an assigned appointment, indicated vt type = kBooking

**Returns:** Integer

```crmscript
NSAppointment thing;
Integer motherId  = thing.GetMotherId();
```

