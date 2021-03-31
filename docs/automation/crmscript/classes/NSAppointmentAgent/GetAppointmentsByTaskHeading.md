---
title: crmscript_ref_NSAppointmentAgent_GetAppointmentsByTaskHeading
description: AppointmentArray GetAppointmentsByTaskHeading(Integer taskHeadingId)
intellisense: NSAppointmentAgent.GetAppointmentsByTaskHeading
keywords: NSAppointmentAgent,GetAppointmentsByTaskHeading
so.topic: reference
---

Method that returns appointments of a specific appointment task heading. Task represents the different types of activities, like “Phone call”, “Meeting” and so on. The heading represents a grouping or filtering of tasks.

**Parameters:**
 - **taskHeadingId** The task heading id. The heading represents a grouping or filtering of tasks. Task represents the different types of activities, like “Phone call”, “Meeting” and so on

**Returns:** Array of Appointments.

```crmscript
NSAppointmentAgent agent;
Integer taskHeadingId;
AppointmentArray res = agent.GetAppointmentsByTaskHeading(taskHeadingId);
```

