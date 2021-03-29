---
title: crmscript_ref_NSAppointmentAgent_GetPersonAppointmentsByType_Integer_p_0_Bool_p_1_DateTime_p_2_DateTime_p_3_Integer_p_4_Integer_p_5
description: NSAppointmentAgent.GetPersonAppointmentsByType(Integer p_0, Bool p_1, DateTime p_2, DateTime p_3, Integer p_4, Integer p_5)
intellisense: NSAppointmentAgent.GetPersonAppointmentsByType
sortOrder: 856
keywords: GetPersonAppointmentsByType(Integer,Bool,DateTime,DateTime,Integer,Integer)
so.topic: reference
---


Method that returns a specified number of appointments of a specific appointment type within a time range. The appointments belong to the person specified.



* **personId:** The person id of the SuperOffice user (associate).
* **includeProjectAppointments:** If true, all appointments that belong to projects where the user is a project member are included as well as the appointments belonging to the person.
* **startTime:** The start of the time interval we want appointments from. This will usually be the current time.
* **endTime:** The end of the time interval.
* **count:** The maximum number of appointments that should be returned. -1 means no count restrictions.
* **appointmentType:** The appointment type, e.g. inDiary, inChecklist etc.
* **Returns:** Array of Appointments.


