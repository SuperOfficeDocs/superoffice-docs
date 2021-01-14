---
title: NSAppointment[] GetProjectAppointments(Integer projectId, DateTime startTime, DateTime endTime, Integer count)
path: /EJScript/Classes/NSAppointmentAgent/Member functions/NSAppointment[] GetProjectAppointments(Integer p_0, DateTime p_1, DateTime p_2, Integer p_3)
intellisense: 1
classref: 1
sortOrder: 859
keywords: GetProjectAppointments(Integer,DateTime,DateTime,Integer)
---


Method that returns a specified number of appointments within a time range. The appointments belong to the project specified. If the logged on user is not allowed to view this projects appointments an exception is thrown.



* **projectId:** The project id
* **startTime:** The start of the time interval we want appointments from. This will usually be the current time.
* **endTime:** The end of the time interval.
* **count:** The maximum number of appointments that should be returned. -1 means no count restrictions.
* **Returns:** Array of Appointments.


