---
uid: crmscript_ref_NSAppointmentAgent_GetPersonAppointmentsByType
title: Appointment[] GetPersonAppointmentsByType(Integer personId, Bool includeProjectAppointments, DateTime startTime, DateTime endTime, Integer count, Integer appointmentType)
intellisense: NSAppointmentAgent.GetPersonAppointmentsByType
keywords: NSAppointmentAgent, GetPersonAppointmentsByType
so.topic: reference
---

Method that returns a specified number of appointments of a specific appointment type within a time range. The appointments belong to the person specified.

**Parameters:**
 - **personId** The person id of the SuperOffice user (associate).
 - **includeProjectAppointments** If true, all appointments that belong to projects where the user is a project member are included as well as the appointments belonging to the person.
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

**Returns:** Array of Appointments.

```crmscript
NSAppointmentAgent agent;
Integer personId;
Bool includeProjectAppointments;
DateTime startTime;
DateTime endTime;
Integer count;
Integer appointmentType;
Appointment[] res = agent.GetPersonAppointmentsByType(personId, includeProjectAppointments, startTime, endTime, count, appointmentType);
```

