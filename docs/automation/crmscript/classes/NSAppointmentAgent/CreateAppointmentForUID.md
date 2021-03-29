---
title: crmscript_ref_NSAppointmentAgent_CreateAppointmentForUID_NSAppointmentEntity_p_0_String_p_1
description: NSAppointmentAgent.CreateAppointmentForUID(NSAppointmentEntity p_0, String p_1)
intellisense: NSAppointmentAgent.CreateAppointmentForUID
sortOrder: 873
keywords: CreateAppointmentForUID(NSAppointmentEntity,String)
so.topic: reference
---


Create an invitation record and an appointment with a given UID to reserve it if the UID is unused, otherwise null.



* **appointmentEntity
\param** p1 uID: The UID associated with the appointment
* **Returns:** The newly created AppointmentEntity or null if the UID is in the DB already.


