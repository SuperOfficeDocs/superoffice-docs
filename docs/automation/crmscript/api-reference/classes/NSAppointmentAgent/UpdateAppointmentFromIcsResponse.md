---
uid: crmscript_ref_NSAppointmentAgent_UpdateAppointmentFromIcsResponse
title: Bool UpdateAppointmentFromIcsResponse(String emailAddress, NSStream icsData)
intellisense: NSAppointmentAgent.UpdateAppointmentFromIcsResponse
keywords: NSAppointmentAgent, UpdateAppointmentFromIcsResponse
so.topic: reference
---

Update the attendance to an appointment based on incoming ICS RSVPs.

**Parameters:**
 - **emailAddress** The email-address of the person responding to our meeting-request.
 - **icsData** The iCal ICS RSVP-content in byte-form.

**Returns:** True if successfull.

```crmscript
NSAppointmentAgent agent;
String emailAddress;
NSStream icsData;
Bool res = agent.UpdateAppointmentFromIcsResponse(emailAddress, icsData);
```

