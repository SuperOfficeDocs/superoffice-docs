---
uid: crmscript_ref_NSEMailAgent_GetEmailAppointment
title: NSEMailAppointment GetEmailAppointment(Integer mailItemId)
intellisense: NSEMailAgent.GetEmailAppointment
keywords: NSEMailAgent, GetEmailAppointment
so.topic: reference
---

Get appointment data contained in the emails iCal attachment

**Parameters:**
 - **mailItemId** Id identifying the email

**Returns:** NSEMailAppointment

```crmscript
NSEMailAgent agent;
Integer mailItemId;
NSEMailAppointment res = agent.GetEmailAppointment(mailItemId);
```

