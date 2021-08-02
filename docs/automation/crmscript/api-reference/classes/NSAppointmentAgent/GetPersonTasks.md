---
uid: crmscript_ref_NSAppointmentAgent_GetPersonTasks
title: NSAppointment[] GetPersonTasks(Integer personId, Integer count)
intellisense: NSAppointmentAgent.GetPersonTasks
keywords: NSAppointmentAgent, GetPersonTasks
so.topic: reference
---

Method that returns a specified number of appointments within a time range. It only returns appointments that would be displayed in the user's task list. The appointments belong to the person specified. If the person not is a SuperOffice user (associate) or the logged on user is not allowed to view this persons appointments an exception is thrown.

**Parameters:**
 - **personId** The person id of the SuperOffice user (associate).
 - **count** The maximum number of appointments that should be returned. -1 means no count restrictions.

**Returns:** NSAppointment[]

```crmscript
NSAppointmentAgent agent;
Integer personId;
Integer count;
NSAppointment[] res = agent.GetPersonTasks(personId, count);
```

