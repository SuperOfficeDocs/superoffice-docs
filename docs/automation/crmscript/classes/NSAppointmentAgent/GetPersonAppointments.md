---
title: NSAppointment[] GetPersonAppointments(Integer personId, Bool includeProjectAppointments, DateTime startTime, DateTime endTime, Integer count)
path: /EJScript/Classes/NSAppointmentAgent/Member functions/NSAppointment[] GetPersonAppointments(Integer p_0, Bool p_1, DateTime p_2, DateTime p_3, Integer p_4)
intellisense: 1
classref: 1
sortOrder: 852
keywords: GetPersonAppointments(Integer,Bool,DateTime,DateTime,Integer)
---


Method that returns a specified number of appointments within a time range. The appointments belong to the person specified. If the person not is a SuperOffice user (associate) or the logged on user is not allowed to view this persons appointments an exception is thrown.



* **personId:** The person id of the SuperOffice user (associate).
* **includeProjectAppointments:** If true, all appointments that belong to projects where the user is a project member are included as well as the appointments belonging to the person.
* **startTime:** The start of the time interval we want appointments from. This will usually be the current time.
* **endTime:** The end of the time interval.
* **count:** The maximum number of appointments that should be returned. -1 means no count restrictions.
* **Returns:** Array of Appointments.


