---
title: NSAppointment[] GetPersonAppointmentsByTask(Integer personId, Bool includeProjectAppointments, DateTime startTime, DateTime endTime, Integer count, Integer taskId)
path: /EJScript/Classes/NSAppointmentAgent/Member functions/NSAppointment[] GetPersonAppointmentsByTask(Integer p_0, Bool p_1, DateTime p_2, DateTime p_3, Integer p_4, Integer p_5)
intellisense: 1
classref: 1
sortOrder: 853
keywords: GetPersonAppointmentsByTask(Integer,Bool,DateTime,DateTime,Integer,Integer)
---


Method that returns a specified number of appointments of a specific appointment task type within a time range. The appointments belong to the person specified.  Task represents the different types of activities, like “Phone call”, “Meeting” and so on.



* **personId:** The person id of the SuperOffice user (associate).
* **includeProjectAppointments:** If true, all appointments that belong to projects where the user is a project member are included as well as the appointments belonging to the person.
* **startTime:** The start of the time interval we want appointments from. This will usually be the current time.
* **endTime:** The end of the time interval.
* **count:** The maximum number of appointments that should be returned. -1 means no count restrictions.
* **taskId:** The task id. Task represents the different types of activities, like “Phone call”, “Meeting” and so on.
* **Returns:** Array of Appointments.


