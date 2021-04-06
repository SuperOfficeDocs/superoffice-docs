---
uid: crmscript_ref_NSAppointmentAgent_Move
title: AppointmentEntity Move(Integer appointmentId, DateTime newStartTime, Integer updateMode)
intellisense: NSAppointmentAgent.Move
keywords: NSAppointmentAgent, Move
so.topic: reference
---

Moving a booking to another start time.

**Parameters:**
 - **appointmentId** The appointmentId. Both master and child record ids are accepted.
 - **newStartTime** The new start time for the moved booking.
 - **updateMode** Update mode for a recurring appointment.
     - Enum: 0 = Unknown 
     - Enum: 1 = OnlyThis 
     - Enum: 2 = ThisAndForward 
     - Enum: 9 = StopRecurrence 

**Returns:** Updated AppointmentEntity

```crmscript
NSAppointmentAgent agent;
Integer appointmentId;
DateTime newStartTime;
Integer updateMode;
AppointmentEntity res = agent.Move(appointmentId, newStartTime, updateMode);
```

