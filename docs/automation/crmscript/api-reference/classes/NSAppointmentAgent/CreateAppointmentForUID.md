---
uid: crmscript_ref_NSAppointmentAgent_CreateAppointmentForUID
title: NSAppointmentEntity CreateAppointmentForUID(NSAppointmentEntity appointmentEntity, String uID)
intellisense: NSAppointmentAgent.CreateAppointmentForUID
keywords: NSAppointmentAgent, CreateAppointmentForUID
so.topic: reference
---

Create an invitation record and an appointment with a given UID to reserve it if the UID is unused, otherwise null.

**Parameters:**
 - **appointmentEntity** 
 - **uID** The UID associated with the appointment

**Returns:** The newly created NSAppointmentEntity or null if the UID is in the DB already.

```crmscript
NSAppointmentAgent agent;
NSAppointmentEntity appointmentEntity;
String uID;
NSAppointmentEntity res = agent.CreateAppointmentForUID(appointmentEntity, uID);
```

