---
uid: crmscript_ref_NSAlarmData_GetAssignmentStatus
title: Integer GetAssignmentStatus()
intellisense: NSAlarmData.GetAssignmentStatus
keywords: NSAlarmData, GetAssignmentStatus
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
NSAlarmData thing;
Integer assignmentStatus  = thing.GetAssignmentStatus();
```

