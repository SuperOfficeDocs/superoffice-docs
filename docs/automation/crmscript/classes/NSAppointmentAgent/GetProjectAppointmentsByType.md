---
title: crmscript_ref_NSAppointmentAgent_GetProjectAppointmentsByType_Integer_p_0_DateTime_p_1_DateTime_p_2_Integer_p_3_Integer_p_4
description: NSAppointmentAgent.GetProjectAppointmentsByType(Integer p_0, DateTime p_1, DateTime p_2, Integer p_3, Integer p_4)
intellisense: NSAppointmentAgent.GetProjectAppointmentsByType
sortOrder: 863
keywords: GetProjectAppointmentsByType(Integer,DateTime,DateTime,Integer,Integer)
so.topic: reference
---


Method that returns a specified number of appointments of a specific appointment type within a time range. The appointments belong to the project specified.



* **projectId:** The project id
* **startTime:** The start of the time interval we want appointments from. This will usually be the current time.
* **endTime:** The end of the time interval.
* **count:** The maximum number of appointments that should be returned. -1 means no count restrictions.
* **appointmentType:** The appointment type, e.g. inDiary, inChecklist etc.
* **Returns:** Array of Appointments.


