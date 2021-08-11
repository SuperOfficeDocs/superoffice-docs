---
uid: crmscript_ref_NSAppointment_GetAssignmentStatus
title: Integer GetAssignmentStatus()
intellisense: NSAppointment.GetAssignmentStatus
keywords: NSAppointment, GetAssignmentStatus
so.topic: reference
---

# Integer GetAssignmentStatus()

Status if this appointment is in the process of being assigned to someone else

**Returns:** Integer

     - Enum: 0 = Unknown 
     - Enum: 1 = None 
     - Enum: 11 = Assigning 
     - Enum: 12 = Seen 
     - Enum: 13 = Declined 

```crmscript
NSAppointment thing;
Integer assignmentStatus  = thing.GetAssignmentStatus();
```

