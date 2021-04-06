---
uid: crmscript_ref_NSAppointmentAgent_GetAppointmentFromUID
title: AppointmentEntity GetAppointmentFromUID(String uID)
intellisense: NSAppointmentAgent.GetAppointmentFromUID
keywords: NSAppointmentAgent, GetAppointmentFromUID
so.topic: reference
---

Get the appointment that corresponds to the given UID.

**Parameters:**
 - **uID** The UID associated with the appointment

**Returns:** The corresponding AppointmentEntity if exists or a default appointment entity.

```crmscript
NSAppointmentAgent agent;
String uID;
AppointmentEntity res = agent.GetAppointmentFromUID(uID);
```

