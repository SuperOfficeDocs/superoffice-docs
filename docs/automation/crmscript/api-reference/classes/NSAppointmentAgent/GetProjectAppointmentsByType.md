---
uid: crmscript_ref_NSAppointmentAgent_GetProjectAppointmentsByType
title: NSAppointment[] GetProjectAppointmentsByType(Integer projectId, DateTime startTime, DateTime endTime, Integer count, Integer appointmentType)
intellisense: NSAppointmentAgent.GetProjectAppointmentsByType
keywords: NSAppointmentAgent, GetProjectAppointmentsByType
so.topic: reference
---

Method that returns a specified number of appointments of a specific appointment type within a time range. The appointments belong to the project specified.

**Parameters:**
 - **projectId** The project id
 - **startTime** The start of the time interval we want appointments from. This will usually be the current time.
 - **endTime** The end of the time interval.
 - **count** The maximum number of appointments that should be returned. -1 means no count restrictions.
 - **appointmentType** The appointment type, e.g. inDiary, inChecklist etc.
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

**Returns:** NSAppointment[]

```crmscript
NSAppointmentAgent agent;
Integer projectId;
DateTime startTime;
DateTime endTime;
Integer count;
Integer appointmentType;
NSAppointment[] res = agent.GetProjectAppointmentsByType(projectId, startTime, endTime, count, appointmentType);
```

