---
uid: crmscript_ref_NSEMailAgent_GetEmailAppointmentRecurrence
title: NSRecurrenceInfo GetEmailAppointmentRecurrence(Integer mailItemId)
intellisense: NSEMailAgent.GetEmailAppointmentRecurrence
keywords: NSEMailAgent, GetEmailAppointmentRecurrence
so.topic: reference
---

# NSRecurrenceInfo GetEmailAppointmentRecurrence(Integer mailItemId)

Get recurrence data contained in the email iCal attachment

**Parameters:**
 - **mailItemId** Id identifying the email

**Returns:** NSRecurrenceInfo

```crmscript
NSEMailAgent agent;
Integer mailItemId;
NSRecurrenceInfo res = agent.GetEmailAppointmentRecurrence(mailItemId);
```

