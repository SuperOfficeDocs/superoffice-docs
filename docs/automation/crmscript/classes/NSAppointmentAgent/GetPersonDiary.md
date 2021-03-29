---
title: crmscript_ref_NSAppointmentAgent_GetPersonDiary_Integer_p_0_DateTime_p_1_DateTime_p_2_Integer_p_3
description: NSAppointmentAgent.GetPersonDiary(Integer p_0, DateTime p_1, DateTime p_2, Integer p_3)
intellisense: NSAppointmentAgent.GetPersonDiary
sortOrder: 857
keywords: GetPersonDiary(Integer,DateTime,DateTime,Integer)
so.topic: reference
---


Method that returns a specified number of appointments within a time range. It only returns appointments that would be displayed in the user's diary. The appointments belong to the person specified. If the person not is a SuperOffice user (associate) or the logged on user is not allowed to view this persons appointments an exception is thrown.



* **personId:** The person id of the SuperOffice user (associate).
* **startTime:** The start of the time interval we want appointments from. This will usually be the current time.
* **endTime:** The end of the time interval.
* **count:** The maximum number of appointments that should be returned. -1 means no count restrictions.
* **Returns:** Array of Appointments.


