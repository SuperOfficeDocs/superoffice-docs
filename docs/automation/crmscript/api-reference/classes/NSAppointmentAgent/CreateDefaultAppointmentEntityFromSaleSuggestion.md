---
uid: crmscript_ref_NSAppointmentAgent_CreateDefaultAppointmentEntityFromSaleSuggestion
title: NSAppointmentEntity CreateDefaultAppointmentEntityFromSaleSuggestion(Integer suggestedAppointmentId, Integer saleId, Bool createNow, Integer ownerId)
intellisense: NSAppointmentAgent.CreateDefaultAppointmentEntityFromSaleSuggestion
keywords: NSAppointmentAgent, CreateDefaultAppointmentEntityFromSaleSuggestion
so.topic: reference
---

Creates an appointment based on a suggested appointment. 

**Parameters:**
 - **suggestedAppointmentId** The id of the suggested appointment
 - **saleId** This is the id of the sale the appointment is connected to. This will be used to give the appointment it's starting date. If the id is 0 or invalid, we assume the start date is now
 - **createNow** If this parameter is true, we override the suggested start time and create the appointment with the current date and time
 - **ownerId** 

**Returns:** The newly created appointment

```crmscript
NSAppointmentAgent agent;
Integer suggestedAppointmentId;
Integer saleId;
Bool createNow;
Integer ownerId;
NSAppointmentEntity res = agent.CreateDefaultAppointmentEntityFromSaleSuggestion(suggestedAppointmentId, saleId, createNow, ownerId);
```

