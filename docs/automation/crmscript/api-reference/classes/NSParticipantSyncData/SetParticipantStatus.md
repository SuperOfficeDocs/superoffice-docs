---
uid: crmscript_ref_NSParticipantSyncData_SetParticipantStatus
title: SetParticipantStatus(Integer participantStatus)
intellisense: NSParticipantSyncData.SetParticipantStatus
keywords: NSParticipantSyncData, GetParticipantStatus
so.topic: reference
---

# SetParticipantStatus(Integer participantStatus)

The appointment status for this participant.

**Parameter:** 
 - **participantStatus** Integer
     - Enum: 0 = UnknownOrPostIt 
     - Enum: 1 = NotStarted 
     - Enum: 2 = Started 
     - Enum: 3 = Completed 
     - Enum: 4 = Hidden 
     - Enum: 5 = Booking 
     - Enum: 6 = BookingMoved 
     - Enum: 7 = BookingSeen 
     - Enum: 8 = BookingMovedSeen 
     - Enum: 9 = BookingDeclined 
     - Enum: 10 = BookingDeleted 
     - Enum: 11 = Assignment 
     - Enum: 12 = AssignmentSeen 
     - Enum: 13 = AssignmentDeclined 

```crmscript
NSParticipantSyncData thing;
Integer participantStatus;
thing.SetParticipantStatus(participantStatus);
```

