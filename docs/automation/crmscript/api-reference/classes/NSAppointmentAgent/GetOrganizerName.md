---
uid: crmscript_ref_NSAppointmentAgent_GetOrganizerName
title: String GetOrganizerName(Integer motherAppointmentId)
intellisense: NSAppointmentAgent.GetOrganizerName
keywords: NSAppointmentAgent, GetOrganizerName
so.topic: reference
---

Lookup the name / email of an event-organizer

**Parameters:**
 - **motherAppointmentId** The id of the mother-appointment.

**Returns:** The displayed name of the organizer: name or email

```crmscript
NSAppointmentAgent agent;
Integer motherAppointmentId;
String res = agent.GetOrganizerName(motherAppointmentId);
```

