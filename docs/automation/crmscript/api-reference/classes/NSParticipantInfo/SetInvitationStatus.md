---
uid: crmscript_ref_NSParticipantInfo_SetInvitationStatus
title: SetInvitationStatus(Integer invitationStatus)
intellisense: NSParticipantInfo.SetInvitationStatus
keywords: NSParticipantInfo, GetInvitationStatus
so.topic: reference
---

# SetInvitationStatus(Integer invitationStatus)

The participant status for the appointment

**Parameter:** 
 - **invitationStatus** Integer
     - Enum: 0 = Unknown 
     - Enum: 1 = None 
     - Enum: 2 = Accepted 
     - Enum: 4 = Hidden 
     - Enum: 5 = Invitation 
     - Enum: 6 = Moved 
     - Enum: 7 = Seen 
     - Enum: 8 = MovedSeen 
     - Enum: 9 = Declined 
     - Enum: 10 = Cancelled 

```crmscript
NSParticipantInfo thing;
Integer invitationStatus;
thing.SetInvitationStatus(invitationStatus);
```

