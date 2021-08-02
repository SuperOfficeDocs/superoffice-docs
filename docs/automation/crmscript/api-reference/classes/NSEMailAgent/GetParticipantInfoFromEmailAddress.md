---
uid: crmscript_ref_NSEMailAgent_GetParticipantInfoFromEmailAddress
title: NSPerson GetParticipantInfoFromEmailAddress(String emailAddress, Integer appointmentId)
intellisense: NSEMailAgent.GetParticipantInfoFromEmailAddress
keywords: NSEMailAgent, GetParticipantInfoFromEmailAddress
so.topic: reference
---

Get participant data associated with the participant in the emails iCal attachment

**Parameters:**
 - **emailAddress** Email address of participant
 - **appointmentId** Appointment id of participant

**Returns:** NSPerson

```crmscript
NSEMailAgent agent;
String emailAddress;
Integer appointmentId;
NSPerson res = agent.GetParticipantInfoFromEmailAddress(emailAddress, appointmentId);
```

