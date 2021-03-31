---
uid: crmscript_ref_NSEMailAgent_GetParticipantInfoFromEmailAddress
title: Person GetParticipantInfoFromEmailAddress(String emailAddress, Integer appointmentId)
intellisense: NSEMailAgent.GetParticipantInfoFromEmailAddress
keywords: NSEMailAgent, GetParticipantInfoFromEmailAddress
so.topic: reference
---

Get participant data associated with the participant in the emails iCal attachment

**Parameters:**
 - **emailAddress** Email address of participant
 - **appointmentId** Appointment id of participant

**Returns:** Person information

```crmscript
NSEMailAgent agent;
String emailAddress;
Integer appointmentId;
Person res = agent.GetParticipantInfoFromEmailAddress(emailAddress, appointmentId);
```

