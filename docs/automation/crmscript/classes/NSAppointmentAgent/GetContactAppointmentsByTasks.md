---
title: crmscript_ref_NSAppointmentAgent_GetContactAppointmentsByTasks_Integer_p_0_DateTime_p_1_DateTime_p_2_Integer_p_3_Integer__p_4
description: NSAppointmentAgent.GetContactAppointmentsByTasks(Integer p_0, DateTime p_1, DateTime p_2, Integer p_3, Integer[] p_4)
intellisense: NSAppointmentAgent.GetContactAppointmentsByTasks
sortOrder: 845
keywords: GetContactAppointmentsByTasks(Integer,DateTime,DateTime,Integer,Integer[])
so.topic: reference
---


Method that returns a specified number of appointments belonging to an array of appointment task types within a time range. The appointments belong to the contact specified. Task represents the different types of activities, like “Phone call”, “Meeting” and so on.



* **contactId:** The contact id
* **startTime:** The start of the time interval we want appointments from. This will usually be the current time.
* **endTime:** The end of the time interval.
* **count:** The maximum number of appointments that should be returned. -1 means no count restrictions.
* **taskIds:** The task ids as an integer array. Task represents the different types of activities, like “Phone call”, “Meeting” and so on.
* **Returns:** Array of Appointments.


