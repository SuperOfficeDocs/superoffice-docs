---
uid: crmscript_ref_NSAlarmData_GetAppointmentType
title: Integer GetAppointmentType()
intellisense: NSAlarmData.GetAppointmentType
keywords: NSAlarmData, GetAppointmentType
so.topic: reference
---

# Integer GetAppointmentType()

where=no start time,note,docin, docout 

**Returns:** Integer

     - Enum: 0 = Unknown 
     - Enum: 1 = inDiary 
     - Enum: 2 = inChecklist 
     - Enum: 3 = Note 
     - Enum: 4 = Document 
     - Enum: 5 = SavedReport 
     - Enum: 6 = BookingForDiary 
     - Enum: 7 = BookingForChecklist 
     - Enum: 8 = MergeDraft 
     - Enum: 9 = MergeFinal 

```crmscript
NSAlarmData thing;
Integer appointmentType  = thing.GetAppointmentType();
```

