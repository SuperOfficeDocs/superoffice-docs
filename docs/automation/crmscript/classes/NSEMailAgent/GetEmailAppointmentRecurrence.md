---
title: crmscript_ref_NSEMailAgent_GetEmailAppointmentRecurrence
description: RecurrenceInfo GetEmailAppointmentRecurrence(Integer mailItemId)
intellisense: NSEMailAgent.GetEmailAppointmentRecurrence
keywords: NSEMailAgent,GetEmailAppointmentRecurrence
so.topic: reference
---

Get recurrence data contained in the email iCal attachment

**Parameters:**
 - **mailItemId** Id identifying the email

**Returns:** Recurrence information

```crmscript
NSEMailAgent agent;
Integer mailItemId;
RecurrenceInfo res = agent.GetEmailAppointmentRecurrence(mailItemId);
```

