---
uid: crmscript_ref_NSAppointment_SetMotherId
title: SetMotherId(Integer motherId)
intellisense: NSAppointment.SetMotherId
keywords: NSAppointment, GetMotherId
so.topic: reference
---

# SetMotherId(Integer motherId)

ID of mother appointment; self if booking master, master ID if booking slave, 0 if normal appointment. However, if 0 and assoc_id != reg_id then this is an assigned appointment, indicated vt type = kBooking

**Parameter:** 
 - **motherId** Integer

```crmscript
NSAppointment thing;
Integer motherId;
thing.SetMotherId(motherId);
```

