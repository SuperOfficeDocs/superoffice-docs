---
uid: crmscript_ref_NSAppointmentEntity_GetBookingType
title: Integer GetBookingType()
intellisense: NSAppointmentEntity.GetBookingType
keywords: NSAppointmentEntity, GetBookingType
so.topic: reference
---

The type of booking the appointment represents

**Returns:** Integer

     - Enum: 0 = Unknown 
     - Enum: 1 = None 
     - Enum: 2 = Owner 
     - Enum: 3 = Participant 

```crmscript
NSAppointmentEntity thing;
Integer bookingType  = thing.GetBookingType();
```


