---
title: crmscript_ref_NSAppointmentAgent_GetPersonAppointments_Integer_p_0_Bool_p_1_DateTime_p_2_DateTime_p_3_Integer_p_4
description: NSAppointmentAgent.GetPersonAppointments(Integer p_0, Bool p_1, DateTime p_2, DateTime p_3, Integer p_4)
intellisense: NSAppointmentAgent.GetPersonAppointments
sortOrder: 852
keywords: GetPersonAppointments(Integer,Bool,DateTime,DateTime,Integer)
so.topic: reference
---


Method that returns a specified number of appointments within a time range. The appointments belong to the person specified. If the person not is a SuperOffice user (associate) or the logged on user is not allowed to view this persons appointments an exception is thrown.



* **personId:** The person id of the SuperOffice user (associate).
* **includeProjectAppointments:** If true, all appointments that belong to projects where the user is a project member are included as well as the appointments belonging to the person.
* **startTime:** The start of the time interval we want appointments from. This will usually be the current time.
* **endTime:** The end of the time interval.
* **count:** The maximum number of appointments that should be returned. -1 means no count restrictions.
* **Returns:** Array of Appointments.


