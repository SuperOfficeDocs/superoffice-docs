---
uid: crmscript_ref_NSAppointmentAgent_GetAppointmentsByTaskHeading
title: NSAppointment[] GetAppointmentsByTaskHeading(Integer taskHeadingId)
intellisense: NSAppointmentAgent.GetAppointmentsByTaskHeading
keywords: NSAppointmentAgent, GetAppointmentsByTaskHeading
so.topic: reference
---

# NSAppointment[] GetAppointmentsByTaskHeading(Integer taskHeadingId)

Method that returns appointments of a specific appointment task heading. Task represents the different types of activities, like “Phone call”, “Meeting” and so on. The heading represents a grouping or filtering of tasks.

**Parameters:**
 - **taskHeadingId** The task heading id. The heading represents a grouping or filtering of tasks. Task represents the different types of activities, like “Phone call”, “Meeting” and so on

**Returns:** NSAppointment[]

```crmscript
NSAppointmentAgent agent;
Integer taskHeadingId;
NSAppointment[] res = agent.GetAppointmentsByTaskHeading(taskHeadingId);
```

