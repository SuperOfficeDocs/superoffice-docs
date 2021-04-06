---
uid: crmscript_ref_NSAppointmentEntity_GetCautionWarning
title: AppointmentCautionWarning GetCautionWarning()
intellisense: NSAppointmentEntity.GetCautionWarning
keywords: NSAppointmentEntity, GetCautionWarning
so.topic: reference
---

Status field to indicate appointments that have some sort of problem

**Returns:** AppointmentCautionWarning

     - Enum: 0 = OK 
     - Enum: 1 = NotInSync 
     - Enum: 2 = NotNotifiedByEmail 
     - Enum: 3 = RecurrencePatternNotSupported 
     - Enum: 4 = IncomingRecurrenceChangeNotSupported 
     - Enum: 5 = ExternalParticipantsDateTimeMismatch 

```crmscript
NSAppointmentEntity thing;
AppointmentCautionWarning cautionWarning  = thing.GetCautionWarning();
```


