---
uid: crmscript_ref_NSAppointmentAgent_SetSeen
title: Void SetSeen(Integer appointmentId, Integer updateMode)
intellisense: NSAppointmentAgent.SetSeen
keywords: NSAppointmentAgent, SetSeen
so.topic: reference
---

Sets an appointment invitiation to seen.

**Parameters:**
 - **appointmentId** The appointmentId. Both master and child record ids are accepted.
 - **updateMode** Update mode for a recurring appointment.
     - Enum: 0 = Unknown 
     - Enum: 1 = OnlyThis 
     - Enum: 2 = ThisAndForward 
     - Enum: 9 = StopRecurrence 
