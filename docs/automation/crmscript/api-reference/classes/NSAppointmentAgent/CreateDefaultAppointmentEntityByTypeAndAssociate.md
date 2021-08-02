---
uid: crmscript_ref_NSAppointmentAgent_CreateDefaultAppointmentEntityByTypeAndAssociate
title: NSAppointmentEntity CreateDefaultAppointmentEntityByTypeAndAssociate(Integer type, Integer associateId)
intellisense: NSAppointmentAgent.CreateDefaultAppointmentEntityByTypeAndAssociate
keywords: NSAppointmentAgent, CreateDefaultAppointmentEntityByTypeAndAssociate
so.topic: reference
---

Creates a NSAppointmentEntity populated with the default values for the specific type and owner.

**Parameters:**
 - **type** The type of task requested.
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
 - **associateId** The associateId of the appointment owner.

**Returns:** NSAppointmentEntity with default values.

```crmscript
NSAppointmentAgent agent;
Integer type;
Integer associateId;
NSAppointmentEntity res = agent.CreateDefaultAppointmentEntityByTypeAndAssociate(type, associateId);
```

