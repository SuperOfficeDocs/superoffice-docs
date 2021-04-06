---
uid: crmscript_ref_NSParticipantSyncData_GetParticipantStatus
title: Integer GetParticipantStatus()
intellisense: NSParticipantSyncData.GetParticipantStatus
keywords: NSParticipantSyncData, GetParticipantStatus
so.topic: reference
---

The appointment status for this participant.

**Returns:** Integer

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
Integer participantStatus  = thing.GetParticipantStatus();
```


