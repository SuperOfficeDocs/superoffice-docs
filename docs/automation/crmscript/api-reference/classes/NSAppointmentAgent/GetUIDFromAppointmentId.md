---
uid: crmscript_ref_NSAppointmentAgent_GetUIDFromAppointmentId
title: String GetUIDFromAppointmentId(Integer appointmentId, Bool useMotherId)
intellisense: NSAppointmentAgent.GetUIDFromAppointmentId
keywords: NSAppointmentAgent, GetUIDFromAppointmentId
so.topic: reference
---

# String GetUIDFromAppointmentId(Integer appointmentId, Bool useMotherId)

Get the UID associated with the appointment id in the Invitation table.

**Parameters:**
 - **appointmentId** 
 - **useMotherId** Uses motherId if no UID is found for appointmentId.

**Returns:** The associated UID, or null if none exist.

```crmscript
NSAppointmentAgent agent;
Integer appointmentId;
Bool useMotherId;
String res = agent.GetUIDFromAppointmentId(appointmentId, useMotherId);
```

