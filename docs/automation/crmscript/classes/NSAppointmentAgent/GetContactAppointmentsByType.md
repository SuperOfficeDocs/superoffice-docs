---
uid: crmscript_ref_NSAppointmentAgent_GetContactAppointmentsByType
title: AppointmentArray GetContactAppointmentsByType(Integer contactId, DateTime startTime, DateTime endTime, Integer count, Integer appointmentType)
intellisense: NSAppointmentAgent.GetContactAppointmentsByType
keywords: NSAppointmentAgent, GetContactAppointmentsByType
so.topic: reference
---

Method that returns a specified number of appointments of a specific appointment type within a time range. The appointments belong to the contact specified. If the logged on user is not allowed to view this contacts appointments an exception is thrown.

**Parameters:**
 - **contactId** The contact id
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
Integer contactId;
DateTime startTime;
DateTime endTime;
Integer count;
Integer appointmentType;
AppointmentArray res = agent.GetContactAppointmentsByType(contactId, startTime, endTime, count, appointmentType);
```

