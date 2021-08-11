---
uid: crmscript_ref_NSAppointment_SetTaskType
title: SetTaskType(Integer taskType)
intellisense: NSAppointment.SetTaskType
keywords: NSAppointment, GetTaskType
so.topic: reference
---

# SetTaskType(Integer taskType)

The different task types of the appointment, if the activity is an appointment, task, phone. See the different types of appointments in the database manual.

**Parameter:** 
 - **taskType** Integer
     - Enum: 0 = Unknown 
     - Enum: 1 = Appointment 
     - Enum: 2 = Document 
     - Enum: 3 = Email 
     - Enum: 4 = Fax 
     - Enum: 5 = Phone 
     - Enum: 6 = ToDo 
     - Enum: 7 = MailMergeDraft 
     - Enum: 8 = MailMergeFinal 
     - Enum: 9 = Report 
     - Enum: 10 = SaintAll 

```crmscript
NSAppointment thing;
Integer taskType;
thing.SetTaskType(taskType);
```

