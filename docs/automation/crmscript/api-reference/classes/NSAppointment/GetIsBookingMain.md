---
uid: crmscript_ref_NSAppointment_GetIsBookingMain
title: Bool GetIsBookingMain()
intellisense: NSAppointment.GetIsBookingMain
keywords: NSAppointment, GetIsBookingMain
so.topic: reference
---

# Bool GetIsBookingMain()

True if this appointment is a booking and current associate is the owner. False if it is a booking and current associate is a participant.

**Returns:** Bool

```crmscript
NSAppointment thing;
Bool isBookingMain  = thing.GetIsBookingMain();
```

