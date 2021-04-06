---
uid: crmscript_ref_NSAppointmentAgent_Accept
title: Void Accept(Integer appointmentId, Integer updateMode)
intellisense: NSAppointmentAgent.Accept
keywords: NSAppointmentAgent, Accept
so.topic: reference
---

Accepting an appointment invitation.

**Parameters:**
 - **appointmentId** The appointmentId. Both master and child record ids are accepted.
 - **updateMode** Update mode for a recurring appointment.
     - Enum: 0 = Unknown 
     - Enum: 1 = OnlyThis 
     - Enum: 2 = ThisAndForward 
     - Enum: 9 = StopRecurrence 

**Returns:** Updated AppointmentEntity

```crmscript
NSAppointmentAgent agent;
Integer appointmentId;
Integer updateMode;
Void res = agent.Accept(appointmentId, updateMode);
```

