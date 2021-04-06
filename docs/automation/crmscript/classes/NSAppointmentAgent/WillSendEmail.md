---
uid: crmscript_ref_NSAppointmentAgent_WillSendEmail
title: Bool WillSendEmail(AppointmentEntity appointment)
intellisense: NSAppointmentAgent.WillSendEmail
keywords: NSAppointmentAgent, WillSendEmail
so.topic: reference
---

Returns true if the changes will trigger email sending on Save, so you can inform the user.

**Parameters:**
 - **appointment** The appointment carrier with changes made, before saving the changes.

**Returns:** True if the changes to the appointment and preference settings etc. indicates an email should be sent.

```crmscript
NSAppointmentAgent agent;
AppointmentEntity appointment;
Bool res = agent.WillSendEmail(appointment);
```

