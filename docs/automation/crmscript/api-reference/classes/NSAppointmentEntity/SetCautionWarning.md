---
uid: crmscript_ref_NSAppointmentEntity_SetCautionWarning
title: SetCautionWarning(NSAppointmentCautionWarning cautionWarning)
intellisense: NSAppointmentEntity.SetCautionWarning
keywords: NSAppointmentEntity, GetCautionWarning
so.topic: reference
---

# SetCautionWarning(NSAppointmentCautionWarning cautionWarning)

Status field to indicate appointments that have some sort of problem

**Parameter:** 
 - **cautionWarning** NSAppointmentCautionWarning
     - Enum: 0 = OK 
     - Enum: 1 = NotInSync 
     - Enum: 2 = NotNotifiedByEmail 
     - Enum: 3 = RecurrencePatternNotSupported 
     - Enum: 4 = IncomingRecurrenceChangeNotSupported 
     - Enum: 5 = ExternalParticipantsDateTimeMismatch 

```crmscript
NSAppointmentEntity thing;
NSAppointmentCautionWarning cautionWarning;
thing.SetCautionWarning(cautionWarning);
```

