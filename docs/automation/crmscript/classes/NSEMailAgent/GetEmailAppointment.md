---
uid: crmscript_ref_NSEMailAgent_GetEmailAppointment
title: EMailAppointment GetEmailAppointment(Integer mailItemId)
intellisense: NSEMailAgent.GetEmailAppointment
keywords: NSEMailAgent, GetEmailAppointment
so.topic: reference
---

Get appointment data contained in the emails iCal attachment

**Parameters:**
 - **mailItemId** Id identifying the email

**Returns:** Appointment data

```crmscript
NSEMailAgent agent;
Integer mailItemId;
EMailAppointment res = agent.GetEmailAppointment(mailItemId);
```

