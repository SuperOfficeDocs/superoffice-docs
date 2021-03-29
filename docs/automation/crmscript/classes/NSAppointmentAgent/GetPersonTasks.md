---
title: crmscript_ref_NSAppointmentAgent_GetPersonTasks_Integer_p_0_Integer_p_1
description: NSAppointmentAgent.GetPersonTasks(Integer p_0, Integer p_1)
intellisense: NSAppointmentAgent.GetPersonTasks
sortOrder: 858
keywords: GetPersonTasks(Integer,Integer)
so.topic: reference
---


Method that returns a specified number of appointments within a time range. It only returns appointments that would be displayed in the user's task list. The appointments belong to the person specified. If the person not is a SuperOffice user (associate) or the logged on user is not allowed to view this persons appointments an exception is thrown.



* **personId:** The person id of the SuperOffice user (associate).
* **count:** The maximum number of appointments that should be returned. -1 means no count restrictions.
* **Returns:** Array of Appointments.


