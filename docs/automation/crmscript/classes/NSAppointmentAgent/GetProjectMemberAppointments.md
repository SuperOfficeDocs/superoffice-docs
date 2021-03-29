---
title: crmscript_ref_NSAppointmentAgent_GetProjectMemberAppointments_Integer_p_0_DateTime_p_1_DateTime_p_2_Integer_p_3
description: NSAppointmentAgent.GetProjectMemberAppointments(Integer p_0, DateTime p_1, DateTime p_2, Integer p_3)
intellisense: NSAppointmentAgent.GetProjectMemberAppointments
sortOrder: 864
keywords: GetProjectMemberAppointments(Integer,DateTime,DateTime,Integer)
so.topic: reference
---


Method that returns a specified number of appointments within a time range. The appointments belong to the projects where the person specified is member.



* **personId:** The project member's person id
* **startTime:** The start of the time interval we want appointments from. This will usually be the current time.
* **endTime:** The end of the time interval.
* **count:** The maximum number of appointments that should be returned. -1 means no count restrictions.
* **Returns:** Array of Appointments.


