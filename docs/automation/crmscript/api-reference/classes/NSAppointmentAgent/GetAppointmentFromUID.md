---
uid: crmscript_ref_NSAppointmentAgent_GetAppointmentFromUID
title: NSAppointmentEntity GetAppointmentFromUID(String uID)
intellisense: NSAppointmentAgent.GetAppointmentFromUID
keywords: NSAppointmentAgent, GetAppointmentFromUID
so.topic: reference
---

Get the appointment that corresponds to the given UID.

**Parameters:**
 - **uID** The UID associated with the appointment

**Returns:** The corresponding NSAppointmentEntity if exists or a default appointment entity.

```crmscript
NSAppointmentAgent agent;
String uID;
NSAppointmentEntity res = agent.GetAppointmentFromUID(uID);
```

