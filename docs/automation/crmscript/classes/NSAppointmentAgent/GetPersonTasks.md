---
title: NSAppointment[] GetPersonTasks(Integer personId, Integer count)
path: /EJScript/Classes/NSAppointmentAgent/Member functions/NSAppointment[] GetPersonTasks(Integer p_0, Integer p_1)
intellisense: 1
classref: 1
sortOrder: 858
keywords: GetPersonTasks(Integer,Integer)
---


Method that returns a specified number of appointments within a time range. It only returns appointments that would be displayed in the user's task list. The appointments belong to the person specified. If the person not is a SuperOffice user (associate) or the logged on user is not allowed to view this persons appointments an exception is thrown.



* **personId:** The person id of the SuperOffice user (associate).
* **count:** The maximum number of appointments that should be returned. -1 means no count restrictions.
* **Returns:** Array of Appointments.


