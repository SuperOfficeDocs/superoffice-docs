---
uid: crmscript_ref_NSAppointmentEntity_GetAssignmentStatus
title: Integer GetAssignmentStatus()
intellisense: NSAppointmentEntity.GetAssignmentStatus
keywords: NSAppointmentEntity, GetAssignmentStatus
so.topic: reference
---

Status if this appointment is in the process of being assigned to someone else

**Returns:** Integer

     - Enum: 0 = Unknown 
     - Enum: 1 = None 
     - Enum: 11 = Assigning 
     - Enum: 12 = Seen 
     - Enum: 13 = Declined 

```crmscript
NSAppointmentEntity thing;
Integer assignmentStatus  = thing.GetAssignmentStatus();
```


