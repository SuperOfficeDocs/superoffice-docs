---
title: crmscript_ref_NSAppointmentAgent_GetPersonAppointmentsByTasks_Integer_p_0_Bool_p_1_DateTime_p_2_DateTime_p_3_Integer_p_4_Integer__p_5
description: NSAppointmentAgent.GetPersonAppointmentsByTasks(Integer p_0, Bool p_1, DateTime p_2, DateTime p_3, Integer p_4, Integer[] p_5)
intellisense: NSAppointmentAgent.GetPersonAppointmentsByTasks
sortOrder: 855
keywords: GetPersonAppointmentsByTasks(Integer,Bool,DateTime,DateTime,Integer,Integer[])
so.topic: reference
---


Method that returns a specified number of appointments from a list of appointment task types within a time range. The appointments belong to the person specified.  Task represents the different types of activities, like “Phone call”, “Meeting” and so on.



* **personId:** The person id of the SuperOffice user (associate).
* **includeProjectAppointments:** If true, all appointments that belong to projects where the user is a project member are included as well as the appointments belonging to the person.
* **startTime:** The start of the time interval we want appointments from. This will usually be the current time.
* **endTime:** The end of the time interval.
* **count:** The maximum number of appointments that should be returned. -1 means no count restrictions.
* **taskIds:** The task ids as an integer array. Task represents the different types of activities, like “Phone call”, “Meeting” and so on.
* **Returns:** Array of Appointments.


