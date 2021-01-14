---
title: NSAppointment[] GetContactAppointmentsByTask(Integer contactId, DateTime startTime, DateTime endTime, Integer count, Integer taskId)
path: /EJScript/Classes/NSAppointmentAgent/Member functions/NSAppointment[] GetContactAppointmentsByTask(Integer p_0, DateTime p_1, DateTime p_2, Integer p_3, Integer p_4)
intellisense: 1
classref: 1
sortOrder: 843
keywords: GetContactAppointmentsByTask(Integer,DateTime,DateTime,Integer,Integer)
---


Method that returns a specified number of appointments of a specific appointment task type within a time range. The appointments belong to the contact specified. Task represents the different types of activities, like “Phone call”, “Meeting” and so on.



* **contactId:** The contact id
* **startTime:** The start of the time interval we want appointments from. This will usually be the current time.
* **endTime:** The end of the time interval.
* **count:** The maximum number of appointments that should be returned. -1 means no count restrictions.
* **taskId:** The task id. Task represents the different types of activities, like “Phone call”, “Meeting” and so on.
* **Returns:** Array of Appointments.


