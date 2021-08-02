---
uid: crmscript_ref_NSAppointment_GetCautionWarning
title: NSAppointmentCautionWarning GetCautionWarning()
intellisense: NSAppointment.GetCautionWarning
keywords: NSAppointment, GetCautionWarning
so.topic: reference
---

Status field to indicate appointments that have some sort of problem

**Returns:** NSAppointmentCautionWarning

     - Enum: 0 = OK 
     - Enum: 1 = NotInSync 
     - Enum: 2 = NotNotifiedByEmail 
     - Enum: 3 = RecurrencePatternNotSupported 
     - Enum: 4 = IncomingRecurrenceChangeNotSupported 
     - Enum: 5 = ExternalParticipantsDateTimeMismatch 

```crmscript
NSAppointment thing;
NSAppointmentCautionWarning cautionWarning  = thing.GetCautionWarning();
```


