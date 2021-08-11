---
uid: crmscript_ref_NSAppointment_SetAssignmentStatus
title: SetAssignmentStatus(Integer assignmentStatus)
intellisense: NSAppointment.SetAssignmentStatus
keywords: NSAppointment, GetAssignmentStatus
so.topic: reference
---

# SetAssignmentStatus(Integer assignmentStatus)

Status if this appointment is in the process of being assigned to someone else

**Parameter:** 
 - **assignmentStatus** Integer
     - Enum: 0 = Unknown 
     - Enum: 1 = None 
     - Enum: 11 = Assigning 
     - Enum: 12 = Seen 
     - Enum: 13 = Declined 

```crmscript
NSAppointment thing;
Integer assignmentStatus;
thing.SetAssignmentStatus(assignmentStatus);
```

